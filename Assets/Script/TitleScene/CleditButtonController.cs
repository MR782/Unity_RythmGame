using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleditButtonController : MonoBehaviour
{
    [Header("フェードイン・アウトのマネージャー")]
    [SerializeField] private FadeManager fadeManager = null;

    /// <summary>
    /// ボタンを押した際に再生されるSE
    /// </summary>
    private AudioSource buttonSE;
    private void Start()
    {
        this.fadeManager = GameObject.Find("FadeManager").GetComponent<FadeManager>();
        this.buttonSE = this.gameObject.GetComponent<AudioSource>();
    }
    //ボタンが押された時の処理
    public void OnClickButton()
    {
        this.buttonSE.Play();
        this.fadeManager.LoadScene("StaffRoll",2.0f);
    }
}
