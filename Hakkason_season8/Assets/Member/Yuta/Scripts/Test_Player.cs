using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの仮操作
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0.0f, 0.0f, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0.0f, 0.0f, -moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Item" && collision.gameObject.name == "Light_Item (+)")
        {
            Test_GameManger.Item = true;
            Test_GameManger.Spot_light = false;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Item" && collision.gameObject.name == "Light_Item (-)")
        {
            Test_GameManger.But_Item = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("クリア");
        }
    }
}
