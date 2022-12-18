using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) 

        { 

            this.transform.Translate(0.0f,0.0f,speed * Time.deltaTime); 

        } 

 
 

        if(Input.GetKey(KeyCode.S)) 

        { 

            this.transform.Translate(0.0f,0.0f,-speed * Time.deltaTime); 

        } 

 
 

        if(Input.GetKey(KeyCode.A)) 

        { 

            this.transform.Translate(-speed * Time.deltaTime,0.0f,0.0f); 

        } 

 
 

        if(Input.GetKey(KeyCode.D)) 

        { 

            this.transform.Translate(speed * Time.deltaTime,0.0f,0.0f); 

        } 
    }
}
