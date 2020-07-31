using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursolController : MonoBehaviour
{
    [Header("楽曲管理オブジェクト")]
    [SerializeField] private MusicDataManager musicDataManager = null;

    [Header("楽曲の置かれているフィールドオブジェクト canvas/ *** ")]
    [SerializeField] private GameObject music_field = null;

    [Header("楽曲の総データ")]
    [SerializeField] private List<MusicInfo> music_alot_info = new List<MusicInfo>();

    const int side_collumNum = 3;//3つで1区切り

    /// <summary>
    /// 選択中の楽曲番号(Index)
    /// </summary>
    [SerializeField]private int select_musicNum;

    // Start is called before the first frame update
    void Start()
    {
        this.musicDataManager = GameObject.Find("MusicDataManager").GetComponent<MusicDataManager>();
        for(int i = 0; i < this.music_field.transform.childCount; i++)
        {
            this.music_alot_info.Add(this.music_field.transform.GetChild(i).GetComponent<MusicInfo>());
        }
        this.select_musicNum = 1;
        this.set(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.ControllCursol())
        {
            this.set(this.select_musicNum);
        }
    }

    //選択中の楽曲情報をマネージャーにセットする
    private void set(int index)
    {
        this.musicDataManager.SetMusicInfo(this.music_alot_info[index]);
    }

    private bool ControllCursol()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.select_musicNum = (this.select_musicNum + side_collumNum) % music_alot_info.Count;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.select_musicNum = (this.select_musicNum + (music_alot_info.Count - side_collumNum)) % music_alot_info.Count;
            return true;
        }
        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    //(NowSelect+1)%eMenu_Num
        //    this.select_musicNum = (this.select_musicNum + 1) % music_alot_info.Count;
        //    return true;
        //}
        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    //(NowSelect+(eMenu_Num-1))%eMenu_Num;
        //    this.select_musicNum = (this.select_musicNum + (music_alot_info.Count - 1)) % music_alot_info.Count;
        //    return true;
        //}
        return false;
    }

}
