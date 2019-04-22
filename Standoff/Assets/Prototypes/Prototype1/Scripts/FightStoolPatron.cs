using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightStoolPatron : MonoBehaviour
{
    int i = 0;
    SaloonManager SM;
    Vector3 v3;
    [SerializeField] private Animator animator;
    void Start()
    {
      
        SM = GameObject.Find("SaloonManager").GetComponent<SaloonManager>();
        foreach (Stool stool in SM.Stools)
        {

            if (SM.Stools[i].isTaken == true)
            {
                Debug.Log("Fighting Patron at Stool " + SM.Stools[i].stoolNum);
                v3 = new Vector3(SM.Stools[i].stoolV3.x, SM.Stools[i].stoolV3.y, -4);
                SM.Stools[i].isTaken = true;
                break;
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, -4), v3, 3 * Time.deltaTime);
        if (transform.position.x == SM.Stools[i].stoolV3.x && transform.position.y == SM.Stools[i].stoolV3.y)
        {
            Destroy(SM.Stools[i].patron);
            this.enabled = false;
        }
          
           
    }
}
