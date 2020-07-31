using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleditButtonController : MonoBehaviour
{
    [SerializeField] private FadeManager fadeManager = null;
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
