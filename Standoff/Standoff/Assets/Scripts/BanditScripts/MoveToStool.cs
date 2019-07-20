using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToStool : MonoBehaviour
{
    
   // public GameObject SMO;
    int i = 0;
    SaloonManager SM;
    Vector3 v3;
    [SerializeField] private Animator animator;
    void Start()
    {
        animator.SetBool("Moving", true);
       // SMO = GameObject.Find("SaloonManager");
        //SM = SMO.GetComponent<SaloonManager>();
        SM = GameObject.Find("SaloonManager").GetComponent<SaloonManager>();
        foreach (Stool stool in SM.Stools)
        {
           
            if (SM.Stools[i].isTaken == false && OnSameLayer(SM.Stools[i].floor))
            {
                //test code to make sure it sees correct layer is not needed here
                GameObject stairCase;
                if (gameObject.layer == 8) { stairCase = GameObject.FindWithTag("Stair1"); } else { stairCase = GameObject.FindWithTag("Stair2"); }

                Debug.Log("moving to " + SM.Stools[i].stoolNum + " on layer " + stairCase.gameObject.tag);
                v3 = new Vector3(SM.Stools[i].stoolV3.x, SM.Stools[i].stoolV3.y, 0);
                SM.Stools[i].isTaken = true;
                SM.Stools[i].patron = gameObject;
                break;
            }



            //test code to get the dummy to change floors to find stool
            if (SM.Stools[i].isTaken == false && !OnSameLayer(SM.Stools[i].floor))
            {
                //will only work for two floors will update it later
                GameObject stairCase;
                if (gameObject.layer == 8) {  stairCase = GameObject.FindWithTag("Stair1"); } else {  stairCase = GameObject.FindWithTag("Stair2"); }
                //GameObject stairCase = GameObject.FindWithTag("Stair2"); //gets an object with the tag of staircase2 
               
                Debug.Log("you are on the wrong floor found staircase " + stairCase.gameObject.tag);
                v3 = new Vector3(stairCase.transform.position.x, stairCase.transform.position.y, 0);
                SM.Stools[i].isTaken = true;
                SM.Stools[i].patron = gameObject;
            }


            i++;
        }
        if (i == SM.Stools.Count)
        {
            Debug.Log("no seats :(");
            enabled = false;
        }


    }

    void Update()
    {
        ///this needs to be modified for moving to stairs
       // Vector3 v3 = new Vector3(SM.Stools[i].stoolV3.x, SM.Stools[i].stoolV3.y, -4);
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, 0),v3, 3 * Time.deltaTime);
        if (transform.position.x == SM.Stools[i].stoolV3.x && transform.position.y == SM.Stools[i].stoolV3.y)
        {
            animator.SetBool("Moving", false);
            enabled = false;
        }
    }


    bool OnSameLayer(int stoolFloor)
    {
        return (gameObject.layer == stoolFloor) ? true : false;
    }
}
