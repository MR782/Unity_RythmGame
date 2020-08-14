using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogbiteInfo : MonoBehaviour
{
    [SerializeField] private int NormalLavel = 3;
    [SerializeField] private int HardLavel = 5;

    [SerializeField] AudioClip music_data = null;
    [SerializeField] AudioClip musicdemo_data = null;
    [SerializeField] Sprite jacket_sprite = null;

    private MusicInfo info = null;
    // Start is called before the first frame update
    void Start()
    {
        this.info = this.gameObject.GetComponent<MusicInfo>();
        this.info.levelList.Add(MusicInfo.Level.Normal, this.NormalLavel);
        this.info.levelList.Add(MusicInfo.Level.Hard, this.HardLavel);

        this.info.data.composer_name = "t+pazolite";
        this.info.data.bpm = 195;


        this.info.data.jacket = this.jacket_sprite;
        this.info.data.demoBGM = this.musicdemo_data;
        this.info.data.music = this.music_data;
    }
}
