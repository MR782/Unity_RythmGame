using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StaffRollController : MonoBehaviour
{
    //　テキストのスクロールスピード
    private const float textScrollSpeed = 20;
    //　テキストの制限位置
    private const float limit_top_PosY = 1250f;
    //スタッフロールのテキスト
    Text staff_roll;


    /// <summary>
    /// フェード管理クラス
    /// </summary>
    [SerializeField] private FadeManager fadeManager = null;
    //BGM管理
    private BackGroundMusicManager bgmManager;
    /// <summary>
    /// シーン変更時に再生されるSE
    /// </summary>
    [SerializeField] private AudioSource sceneChangeSE = null;

    [Header("スタッフロールのBGM(wav,mp3)")]
    [SerializeField] private AudioClip staffrollBGM = null;
    private void Start()
    {
        this.staff_roll = this.gameObject.GetComponent<Text>();
        this.sceneChangeSE = this.gameObject.GetComponent<AudioSource>();
        this.fadeManager = GameObject.Find("FadeManager").GetComponent<FadeManager>();
        this.bgmManager = GameObject.Find("BGMManager").GetComponent<BackGroundMusicManager>();

        this.bgmManager.SetBGM(this.staffrollBGM);
        this.bgmManager.Play(true);
    }

    // Update is called once per frame
    void Update()
    {
        //指定位置まで移動をする
        float Max_posY = Mathf.Min(this.staff_roll.rectTransform.offsetMax.y, limit_top_PosY);
        if (Max_posY < this.staff_roll.rectTransform.offsetMax.y)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                this.sceneChangeSE.Play();
                this.fadeManager.LoadScene("Title", 1.5f);
                this.bgmManager.Stop(true);
            }
            return;
        }
        //限界値まできたら移動を停止
        this.staff_roll.rectTransform.offsetMax = new Vector2(this.staff_roll.rectTransform.offsetMax.x, Max_posY + 1);
    }
}
