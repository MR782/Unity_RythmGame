using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInfo : MonoBehaviour
{
    #region 難易度
    public enum Level
    {
        Normal,
        Hard,
        Extreme
    }
    #endregion

    /// <summary>
    /// 楽曲に必要なデータ構造体
    /// </summary>
    public struct Data
    {
        /// <summary>
        /// 作曲者名
        /// </summary>
        public string composer_name;
        public int bpm;
        /// <summary>
        /// デモ版BGMのファイルネーム
        /// </summary>
        public string demoBGM_filename;
        /// <summary>
        /// //楽曲データのファイルネーム(wav,mp3)
        /// </summary>
        public string music_filename;
        /// <summary>
        /// //ジャケット画像ファイル名
        /// </summary>
        public string jacket_filename;
    }

    public Data data;
    public Dictionary<Level, int> levelList = new Dictionary<Level,int>();//難易度と譜面定数
}
