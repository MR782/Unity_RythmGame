using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartreuseGreenInfo : MonoBehaviour
{
    [SerializeField] private int NormalLavel = 4;
    [SerializeField] private int HardLavel = 6;
    [SerializeField] private int ExtremeLavel = 8;

    private MusicInfo info = null;
    // Start is called before the first frame update
    void Start()
    {
        this.info = this.gameObject.GetComponent<MusicInfo>();
        this.info.levelList.Add(MusicInfo.Level.Normal, this.NormalLavel);
        this.info.levelList.Add(MusicInfo.Level.Hard, this.HardLavel);
        this.info.levelList.Add(MusicInfo.Level.Extreme, this.ExtremeLavel);

        this.info.data.composer_name = "t+pazolite";
        this.info.data.bpm = 180;

        this.info.data.jacket_filename = "ChartreuseGreen";
        this.info.data.demoBGM_filename = "";
        this.info.data.music_filename = "";
    }
}
