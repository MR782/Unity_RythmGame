using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxManager : MonoBehaviour
{
    #region
    [Header("skybox_曲名 : 楽曲ごとのSkyBoxを格納")]
    //[SerializeField] private Material skybox_Metatoron = null;
    [SerializeField] private Material skybox_Air = null;
    //[SerializeField] private Material skybox_Conflict = null;
    //[SerializeField] private Material skybox_Amanogawa = null;
    //[SerializeField] private Material skybox_Monoceros = null;

    //[SerializeField] private Material skybox_new_Tatsh = null;
    //[SerializeField] private Material skybox_Tatsh_Idol = null;
    //[SerializeField] private Material skybox_new_SHIKI = null;
    //[SerializeField] private Material skybox_tpazolite = null;
    #endregion

    //使用しているマテリアル
    [Header("現在ゲームシーンで使用されているSkyBoxのマテリアル")]
    [SerializeField] private Material skybox;

    /// <summary>
    ///SkyBoxの回転速度
    /// </summary>
    const float rotate_speed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        //曲に合わせて背景を変える
        RenderSettings.skybox = skybox_Air;

        skybox = RenderSettings.skybox;
    }

    // Update is called once per frame
    void Update()
    {
        
        //SkyBoxを少しずつ回転させる(360度回転)
        float rotationRepeatValue = Mathf.Repeat(skybox.GetFloat("_Rotation") + rotate_speed, 360f);

        skybox.SetFloat("_Rotation", rotationRepeatValue);
    }
}
