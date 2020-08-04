using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSceneUIManager : MonoBehaviour
{
    #region UIオブジェクトの定義
    [Header("作曲者を表示するテキストオブジェクト")]
    [SerializeField] private Text composer_label = null;

    [Header("BPMを表示するテキストオブジェクト")]
    [SerializeField] private Text bpm_label = null;

    [Header("BPMを表示するテキストオブジェクト")]
    [SerializeField] Image jacket = null;
    #endregion

    /// <summary>
    /// 楽曲データのマネージャー
    /// </summary>
    private MusicDataManager music_dataManager;
    [Header("BGM管理マネージャー")]
    [SerializeField] private BackGroundMusicManager bgmManager = null;
    // Start is called before the first frame update
    void Start()
    {
        this.music_dataManager = GameObject.Find("MusicDataManager").GetComponent<MusicDataManager>();
    }

    // Update is called once per frame
    void Update()
    {
        this.composer_label.text = "作曲者 : " + this.music_dataManager.GetMusicData().data.composer_name;
        this.bpm_label.text = "BPM : " + this.music_dataManager.GetMusicData().data.bpm.ToString();
        this.jacket.sprite = this.music_dataManager.GetMusicData().data.jacket;
    }
}
