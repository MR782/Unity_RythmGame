using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirInfo : MonoBehaviour
{
    [SerializeField] private int NormalLavel = 4;
    [SerializeField] private int HardLavel = 6;
    [SerializeField] private int ExtremeLavel = 7;

    private MusicInfo info = null;
    // Start is called before the first frame update
    void Start()
    {
        this.info = this.gameObject.GetComponent<MusicInfo>();

        this.info.levelList.Add(MusicInfo.Level.Normal, this.NormalLavel);
        this.info.levelList.Add(MusicInfo.Level.Hard, this.HardLavel);
        this.info.levelList.Add(MusicInfo.Level.Extreme, this.ExtremeLavel);

        this.info.data.composer_name = "SHIKI";
        this.info.data.bpm = 178;

        this.info.data.jacket_filename = "AirJacket";
        this.info.data.demoBGM_filename = "";
        this.info.data.music_filename = "";
    }
}
