using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDataManager : MonoBehaviour
{
    private MusicInfo musicInfo = null;//楽曲情報

    #region Singleton
    private static MusicDataManager instance;//インスタンスを管理

    public static MusicDataManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (MusicDataManager)FindObjectOfType(typeof(MusicDataManager));
                //生成されていないならエラーを吐く
                if (instance == null)
                {
                    Debug.LogError(typeof(MusicDataManager) + "is nothing");
                }
            }

            return instance;
        }
    }
    #endregion Singleton
    public void Awake()
    {
        //複数生成されるのを防ぐ
        if (this != Instance)
        {
            Destroy(this.gameObject);
            return;
        }
        //シーンの切り替えで破壊されないようにする
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetMusicInfo(MusicInfo musicInfo)
    {
        this.musicInfo = musicInfo;
    }

    public MusicInfo GetMusicData()
    {
        return this.musicInfo;
    }
}
