using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogbiteInfo : MonoBehaviour
{
    [SerializeField] private int NormalLavel = 3;
    [SerializeField] private int HardLavel = 5;

    private MusicInfo info = null;
    // Start is called before the first frame update
    void Start()
    {
        this.info.levelList.Add(MusicInfo.Level.Normal, this.NormalLavel);
        this.info.levelList.Add(MusicInfo.Level.Hard, this.HardLavel);

        this.info.data.composer_name = "t+pazolite";
        this.info.data.bpm = 195;

        this.info.data.jacket_filename = "";
        this.info.data.demoBGM_filename = "";
        this.info.data.music_filename = "";
    }
}
