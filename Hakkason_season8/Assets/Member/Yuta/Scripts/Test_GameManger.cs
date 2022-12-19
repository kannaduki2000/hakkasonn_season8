using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_GameManger : MonoBehaviour
{
    [SerializeField] GameObject lightObject;
    private float SpotAngle;  //ライトの大きさ
    public static bool Item = false;  //アイテム取得フラグ
    private float time = 0f;  //時間経過記録
    private bool GameOver = false;  //ゲームオーバーフラグ

    void Start()
    {
        //スポットライトのコンポーネント取得
        SpotAngle = lightObject.GetComponent<Light>().spotAngle;
        SpotAngle = 50.0f;  //初期の大きさ
        time = 0f;
        Item = false;
        GameOver = false;
    }

    void Update()
    {
        //ライトの大きさ反映
        lightObject.GetComponent<Light>().spotAngle = SpotAngle;

        time += Time.deltaTime;

        //3秒経つか、ゲームオーバーでは無かったら
        if (time >= 3f && !GameOver)
        {
            //ライトを小さくする
            SpotAngle -= 1f;
            time = 0f;
        }

        //アイテムを取ったら
        if (Item)
        {
            //ライトの大きさを初期に戻す
            SpotAngle = 50.0f;
            Item = false;
        }

        //ライトの大きさが5以下だったら
        if (SpotAngle <= 5f)
        {
            //終わりにする
            GameOver = true;
            Debug.Log("終わり");
        }
    }
}
