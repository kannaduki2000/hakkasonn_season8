using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    public GameObject Player;

    public Text timer;

    //Ö§?õúÔÍÛÁò­ªÎª¿ªáªÎ«Á«§«Ã«¯
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
            //õúÔÍª·ª¿ªé?ßæª·ªÊª¤
        if (collide_player) yield break;
        //õúÔÍª·ª¿ª««Á«§«Ã«¯
        collide_player = true;
        
        Timer.time_Limit = Timer.time_Limit + 20;

        //õúÔÍı­0.5õ©«Ç«£«ì?
        yield return new WaitForSeconds(0.5f);

        collide_player=false;
    }
    
}
