using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursolController : MonoBehaviour
{
    #region オブジェクト定義
    [Header("楽曲管理オブジェクト")]
    [SerializeField] private MusicDataManager musicDataManager = null;

    [Header("楽曲の置かれているフィールドオブジェクト canvas/ *** ")]
    [SerializeField] private GameObject music_field = null;

    [Header("楽曲の総データ")]
    [SerializeField] private List<MusicInfo> music_alot_info = new List<MusicInfo>();

    private AudioSource sound_effect;

    [Header("楽曲管理クラス")]
    [SerializeField] private BackGroundMusicManager bgm_manager = null;
    #endregion

    #region SE定義
    [Header("決定音")]
    [SerializeField] private AudioClip determinationSE = null;
    [Header("カーソルの移動音")]
    [SerializeField] private AudioClip cursolSE = null;
    #endregion

    #region RectTransform
    RectTransform cursolRect = null;
    RectTransform jacketRect = null;
    #endregion

    const int side_collumNum = 3;//3つで1区切り

    /// <summary>
    /// 選択中の楽曲番号(Index)
    /// </summary>
    [SerializeField] private int select_musicNum;

    void Start()
    {
        //定義
        this.sound_effect = this.gameObject.GetComponent<AudioSource>();
        this.musicDataManager = GameObject.Find("MusicDataManager").GetComponent<MusicDataManager>();
        this.bgm_manager = GameObject.Find("BGMManager").GetComponent<BackGroundMusicManager>();

        //楽曲データ取得
        for (int i = 0; i < this.music_field.transform.childCount; i++)
        {
            this.music_alot_info.Add(this.music_field.transform.GetChild(i).GetComponent<MusicInfo>());
        }
        //選択中の楽曲番号
        this.select_musicNum = 0;
        this.cursolRect = this.gameObject.GetComponent<RectTransform>();
        this.jacketRect = this.music_alot_info[this.select_musicNum].gameObject.GetComponent<RectTransform>();
        //ジャケット画像、DEMOBGM、カーソルのセット
        this.set(this.select_musicNum);
        this.CursolSet(select_musicNum);

        RectTransform jacketRect = this.music_alot_info[this.select_musicNum].gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.CursolSet(this.select_musicNum);
        if (this.bgm_manager.IsSeting())
        {
            this.bgm_manager.SetBGM(this.music_alot_info[this.select_musicNum].data.demoBGM);
            this.bgm_manager.Play(true);
        }
        //カーソル操作が行われた際に処理を行う
        if (this.ControllCursol())
        {
            this.setAndplay_SE(this.cursolSE);
            this.set(this.select_musicNum);
            //デモBGM再生
            this.bgm_manager.SetBGM(this.music_alot_info[this.select_musicNum].data.demoBGM);
            this.bgm_manager.Play(true);
        }
    }

    //選択中の楽曲情報をマネージャーにセットする
    public void set(int index)
    {
        this.musicDataManager.SetMusicInfo(this.music_alot_info[index]);
    }

    private bool ControllCursol()
    {
        #region カーソル移動プログラム
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.select_musicNum = (this.select_musicNum + side_collumNum) % music_alot_info.Count;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.select_musicNum = (this.select_musicNum + (music_alot_info.Count - side_collumNum)) % music_alot_info.Count;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.select_musicNum = (this.select_musicNum + 1) % music_alot_info.Count;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.select_musicNum = (this.select_musicNum + (music_alot_info.Count - 1)) % music_alot_info.Count;
            return true;
        }
        #endregion 

        return false;
    }

    private void setAndplay_SE(AudioClip clip)
    {
        this.sound_effect.clip = clip;
        this.sound_effect.Play();
    }

    public void CursolSet(int selectNum)
    {
        RectTransform jacketrect = this.music_alot_info[selectNum].gameObject.GetComponent<RectTransform>();
        if (jacketrect == this.jacketRect) return;

        //カーソルの座標セット
        this.cursolRect.anchoredPosition = jacketrect.anchoredPosition;
        //カーソルサイズセット
        Vector2 size = new Vector2(jacketrect.sizeDelta.x, jacketrect.sizeDelta.y);
        this.cursolRect.sizeDelta = size;

        this.jacketRect = jacketrect;

    }
}
