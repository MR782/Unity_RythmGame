using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursolController : MonoBehaviour
{
    [SerializeField] private MusicDataManager musicDataManager = null;
    /// <summary>
    /// 選択中の楽曲情報
    /// </summary>
    [SerializeField] private MusicInfo select_musicInfo = null;
    // Start is called before the first frame update
    void Start()
    {
        this.musicDataManager = GameObject.Find("").GetComponent<MusicDataManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //選択中の楽曲情報をマネージャーにセットする
    public void set()
    {
        this.musicDataManager.SetMusicInfo(this.select_musicInfo);
    }
}
