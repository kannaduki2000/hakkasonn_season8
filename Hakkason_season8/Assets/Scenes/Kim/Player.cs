using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            player.transform.position -= new Vector3(speed*Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D))
            player.transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
