using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    public GameObject Player;

    public Text timer;

    //֧?�������Ϊ���Ϋ����ë�
    public bool collide_player = false;

    // Start is called before the first frame update
    void Start()
    {
       // timer = GetComponent<Text>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(item_Timer());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
    /*
    [ContextMenu("TimerPlus")]
    public void TimerPlus() => StartCoroutine(item_Timer());
    */

   public IEnumerator item_Timer()
    {
            //���ͪ�����?�檷�ʪ�
        if (collide_player) yield break;
        //���ͪ����������ë�
        collide_player = true;
        
        Timer.time_Limit = Timer.time_Limit + 20;

        //������0.5���ǫ���?
        yield return new WaitForSeconds(0.5f);

        collide_player=false;
    }
    
}
