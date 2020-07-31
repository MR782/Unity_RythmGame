using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class METATRONInfo : MonoBehaviour
{
    [SerializeField] private int HardLavel = 5;
    [SerializeField] private int ExtremeLavel = 8;

    private MusicInfo info = null;
    // Start is called before the first frame update
    void Start()
    {
        this.info.levelList.Add(MusicInfo.Level.Hard, this.HardLavel);
        this.info.levelList.Add(MusicInfo.Level.Extreme, this.ExtremeLavel);

        this.info.data.composer_name = "SHIKI";
        this.info.data.bpm = 190;

        this.info.data.jacket_filename = "";
        this.info.data.demoBGM_filename = "";
        this.info.data.music_filename = "";
    }
}
