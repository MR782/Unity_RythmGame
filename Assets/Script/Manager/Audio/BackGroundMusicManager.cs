using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusicManager : MonoBehaviour
{
    #region Singleton
    private static BackGroundMusicManager instance;//インスタンスを管理

    public static BackGroundMusicManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (BackGroundMusicManager)FindObjectOfType(typeof(BackGroundMusicManager));
                //生成されていないならエラーを吐く
                if (instance == null)
                {
                    Debug.LogError(typeof(BackGroundMusicManager) + "is nothing");
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

        DontDestroyOnLoad(this.gameObject);
    }

    [SerializeField] private AudioSource BGM;
    // Start is called before the first frame update
    void Start()
    {
        this.BGM = this.gameObject.GetComponent<AudioSource>();
    }

    public void SetBGM(string filename)
    {
        this.BGM.clip = Resources.Load<AudioClip>("Audio/bgm/" + filename);
    }

    public void Play(bool Isloop)
    {
        this.BGM.loop = Isloop;
        this.BGM.Play();
    }

    public void Stop(bool Isdelete = false)
    {
        this.BGM.Stop();
        if (Isdelete) this.BGM.clip = null;
    }
}
