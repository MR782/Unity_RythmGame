using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        /// デモ版BGM
        /// </summary>
        public AudioClip demoBGM;
        /// <summary>
        /// //楽曲データ(wav,mp3)
        /// </summary>
        public AudioClip music;
        /// <summary>
        /// //ジャケット画像
        /// </summary>
        public Sprite jacket;
    }

    public Data data;
    public Dictionary<Level, int> levelList = new Dictionary<Level,int>();//難易度と譜面定数
}
