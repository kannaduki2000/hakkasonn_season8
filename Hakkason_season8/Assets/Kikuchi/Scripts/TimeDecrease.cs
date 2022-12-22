using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDecrease : MonoBehaviour
{
    [SerializeField]
    private float decreaseTime = 5.0f;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("アイテム使用");
            GManager.instance.elapsedTime -= decreaseTime;
            Debug.Log("-5秒");
        }
    }
}
