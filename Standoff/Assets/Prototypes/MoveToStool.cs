using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToStool : MonoBehaviour
{
    
    public GameObject SMO;
   
    void Start()
    {
        
        //smt = Transform.FindObjectOfType();
        SMO = GameObject.Find("SaloonManager");
        int i = 0;
        SaloonManager SM = SMO.GetComponent<SaloonManager>();

        foreach (Stool stool in SM.Stools)
        {
            if(SM.Stools[i].isTaken == false)
            {
                Debug.Log("moving to " + SM.Stools[i].stoolNum);
                SM.Stools[i].isTaken = true;
                break;
            }
            i++;
        }


    }

    void Update()
    {
        
    }
}
