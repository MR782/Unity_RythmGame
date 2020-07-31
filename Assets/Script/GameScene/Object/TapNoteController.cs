using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapNoteController : NotesManager
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        this.Move();
    }

    override public JudgeResult Judge(){
        JudgeResult result = JudgeResult.Non;

        //レーンから使用キーを判別
        KeyCode key = this.keys_info[this.lane];
        //キーが押されたら判定を行う
        if (Input.GetKeyDown(key))
        {

        }
        //キーが押されないまま判定ラインを過ぎたらミスとする
        else
        {
            if (true/*LateのGood判定許容値を過ぎたら*/)
            {
                result = JudgeResult.Miss;
            }
        }
        return result;
    }
}
