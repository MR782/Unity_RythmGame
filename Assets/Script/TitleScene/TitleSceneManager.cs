﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneManager : MonoBehaviour
{
    [Header("フェードイン・アウトのマネージャー")]
    [SerializeField] private FadeManager fadeManager = null;

    [Header("BGM管理マネージャー")]
    [SerializeField] private BackGroundMusicManager bgmManager =null;

    [Header("TitleBGM(wav,mp3)")]
    [SerializeField] private AudioClip titleBGM = null;

    private AudioSource scene_cahngeSE;
    // Start is called before the first frame update
    void Start()
    {
        this.fadeManager = GameObject.Find("FadeManager").GetComponent<FadeManager>();
        this.bgmManager = GameObject.Find("BGMManager").GetComponent<BackGroundMusicManager>();
        this.scene_cahngeSE = this.gameObject.GetComponent<AudioSource>();

        this.bgmManager.SetBGM(this.titleBGM);
        this.bgmManager.Play(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Enterキーが押されたら
        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.scene_cahngeSE.Play();
            this.fadeManager.LoadScene("MusicSelect", 1.5f);
            this.bgmManager.Stop(true);
        }
    }
}
