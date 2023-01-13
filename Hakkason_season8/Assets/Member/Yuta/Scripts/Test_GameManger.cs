using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_GameManger : MonoBehaviour
{
    [SerializeField] GameObject lightObject;
    private float SpotAngle; //ライトの大きさ
    private float time = 0f; //時間経過記録
    private bool GameOver = false; //ゲームオーバーフラグ

    public static bool Item = false; //アイテム取得フラグ
    public static bool But_Item = false;
    public static bool Spot_light = false;

    void Start()
    {
        //スポットライトのコンポーネント取得
        SpotAngle = lightObject.GetComponent<Light>().spotAngle;
        SpotAngle = 80.0f;  //初期の大きさ
        time = 0f;
        Item = false;
        But_Item = false;
        GameOver = false;
        Spot_light = false;
    }

    void Update()
    {
        //ライトの大きさ反映
        lightObject.GetComponent<Light>().spotAngle = SpotAngle;

        time += Time.deltaTime;

        //3秒経つか、ゲームオーバーでは無かったら
        if (time >= 2f && !GameOver)
        {
            //ライトを小さくする
            SpotAngle -= 1f;
            time = 0f;
        }

        //アイテムを取ったら
        if (Item)
        {
            //ライトの大きさを初期に戻す
            SpotAngle = 80.0f;
            Item = false;
        }
        if (But_Item)
        {
            SpotAngle -= 5.0f;
            But_Item = false;
        }

        //ライトの大きさが20以下だったら
        if (SpotAngle < 20f)
        {
            //点滅する
            Spot_light = true;
        }
        //ライトの大きさが5以下だったら
        if (SpotAngle <= 5f)
        {
            //ゲームオーバーにする
            GameOver = true;
            Debug.Log("終わり");
        }

        //Lを押したら
        if (Input.GetKey(KeyCode.L))
        {
            //ライトの大きさを20にする
            SpotAngle = 20.0f;
        }
    }
}
