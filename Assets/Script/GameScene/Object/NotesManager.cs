using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesManager : MonoBehaviour
{
    #region レーン番号
    public enum Lane
    {
        D,
        F,
        SPACE,
        J,
        K
    }
    #endregion

    #region ノーツの種類
    public enum NotesKind
    {
        Tap,
        Hold,
        Connect
    }
    #endregion

    #region 判定結果
    public enum JudgeResult
    {
        Non,
        Perfect,
        Good,
        Miss
    }
    #endregion

    #region 変数宣言
    public NotesKind kind;//ノーツの種類
    public Lane lane;//レーン番号
    public JudgeResult judgeResult;//判定結果
    public float perfect_timing;//perfectのタイミング(判定ラインに来る時間)        
    public float hold_time;//ホールドの長さ(ホールド終点のタイミング,タップならperfectと同じ数値)

    public Dictionary<Lane, KeyCode> keys_info = new Dictionary<Lane, KeyCode>();//レーンとキー情報を紐づける
    #endregion

    private void Start()
    {
        this.keys_info.Add(Lane.D, KeyCode.D);
        this.keys_info.Add(Lane.F, KeyCode.F);
        this.keys_info.Add(Lane.J, KeyCode.J);
        this.keys_info.Add(Lane.K, KeyCode.K);
        this.keys_info.Add(Lane.SPACE, KeyCode.Space);
    }


    public void Move()
    {
        //float posY = 0;
        /*
        判定ラインのY座標 + ((パーフェクトタイミング - ゲーム時間) * -(判定ラインY座標) * (0.001f * 速度)
        を
        ノーツ座標(y)に代入
        */
    }

    public virtual JudgeResult Judge()
    {
        JudgeResult result = JudgeResult.Non;

        return result;
    }

    public void SetNoteInfo(Lane lane_no, NotesKind note_kind, float p_timing, float holdtime)
    {
        lane = lane_no;
        kind = note_kind;
        perfect_timing = p_timing;
        hold_time = holdtime;
    }
}
