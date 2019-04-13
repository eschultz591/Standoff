using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditoControllerP : MonoBehaviour
{

    MoveToStool moveToStool;
    FightStoolPatron fightStoolPatron;
    public GameObject Fists;
    void Start()
    {
        moveToStool = this.GetComponent<MoveToStool>();
        fightStoolPatron = this.GetComponent<FightStoolPatron>();
        //Fists = this.GetComponentInChildren<>
       
    }

    // Update is called once per frame
    void Update()
    {
        //Testing code
        if (Input.GetButtonDown("T"))
        {

            moveToStool.enabled = true;

        }
        if (Input.GetButtonDown("F"))
        {
            fightStoolPatron.enabled = true;
        }

    }
}
