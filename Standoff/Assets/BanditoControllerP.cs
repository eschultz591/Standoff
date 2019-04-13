using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditoControllerP : MonoBehaviour
{

    MoveToStool moveToStool;
    void Start()
    {
        moveToStool = this.GetComponent<MoveToStool>();
        moveToStool.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Testing code
        if (Input.GetButtonDown("T"))
        {

            moveToStool.enabled = true;

        }

    }
}
