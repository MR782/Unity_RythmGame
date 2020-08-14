using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class METATRONInfo : MonoBehaviour
{
    [SerializeField] private int HardLavel = 5;
    [SerializeField] private int ExtremeLavel = 8;

    [SerializeField] AudioClip music_data = null;
    [SerializeField] AudioClip musicdemo_data = null;
    [SerializeField] Sprite jacket_sprite = null;

    private MusicInfo info = null;
    // Start is called before the first frame update
    void Start()
    {
        this.info = this.gameObject.GetComponent<MusicInfo>();
        this.info.levelList.Add(MusicInfo.Level.Hard, this.HardLavel);
        this.info.levelList.Add(MusicInfo.Level.Extreme, this.ExtremeLavel);

        this.info.data.composer_name = "SHIKI";
        this.info.data.bpm = 190;


        this.info.data.jacket = this.jacket_sprite;
        this.info.data.demoBGM = this.musicdemo_data;
        this.info.data.music = this.music_data;
    }
}
