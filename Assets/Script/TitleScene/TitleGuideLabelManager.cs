using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleGuideLabelManager : MonoBehaviour
{
    private float delta_time;
    private Text guide_label;
    // Start is called before the first frame update
    void Start()
    {
        this.guide_label = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        this.guide_label.color = UpdateAlphaColor(this.guide_label.color);
    }

    private Color UpdateAlphaColor(Color color)
    {
        this.delta_time += Time.deltaTime * 5.0f;
        color.a = Mathf.Sin(this.delta_time) * 0.5f + 0.5f; 
        return color;
    }
}
