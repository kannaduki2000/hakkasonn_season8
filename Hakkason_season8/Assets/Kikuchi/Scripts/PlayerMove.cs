using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.0f;
    private float moveX = 0.0f;
	private float moveZ = 0.0f;
    // 向き関係
    private Vector3 ySpeed;
    private Vector3 latestPos;
    private Vector3 nowPos;

    //アニメーター
    Animator animator;

	Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        moveX = Input.GetAxis ("Horizontal") * speed;
        moveZ = Input.GetAxis ("Vertical") * speed;

        if( moveX > 0.1 || moveZ > 0.1 || moveX < -0.1 || moveZ < -0.1)
        {
            animator.SetBool("Iswalking",true);
        }
        else
        {
            animator.SetBool("Iswalking",false);
        }

        nowPos = this.transform.position - latestPos;
        nowPos.y = 0;
        latestPos = this.transform.position;
        if (nowPos.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(nowPos); //向きを変更する
        }
        
    }

    void FixedUpdate()
    {
        ySpeed = rb.velocity;
        rb.velocity = new Vector3(moveX,ySpeed.y, moveZ);
    }
}
