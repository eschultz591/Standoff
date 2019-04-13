using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToStool : MonoBehaviour
{
    
   // public GameObject SMO;
    int i = 0;
    SaloonManager SM;
    Vector3 v3;
    void Start()
    {
        
       // SMO = GameObject.Find("SaloonManager");
        //SM = SMO.GetComponent<SaloonManager>();
        SM = GameObject.Find("SaloonManager").GetComponent<SaloonManager>();
        foreach (Stool stool in SM.Stools)
        {
           
            if (SM.Stools[i].isTaken == false)
            {
                Debug.Log("moving to " + SM.Stools[i].stoolNum);
                v3 = new Vector3(SM.Stools[i].stoolV3.x, SM.Stools[i].stoolV3.y, -4);
                SM.Stools[i].isTaken = true;
                SM.Stools[i].patron = this.gameObject;
                break;
            }
            i++;
        }
        if (i == SM.Stools.Count)
        {
            Debug.Log("no seats :(");
            this.enabled = false;
        }


    }

    void Update()
    {
       // Vector3 v3 = new Vector3(SM.Stools[i].stoolV3.x, SM.Stools[i].stoolV3.y, -4);
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, -4),v3, 3 * Time.deltaTime);
        if (transform.position.x == SM.Stools[i].stoolV3.x && transform.position.y == SM.Stools[i].stoolV3.y)
            this.enabled = false;
    }
}
