using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public int cMoney; //money the character has
    public bool interacting; //bool value to see if the interact key was pressed
    public CharacterController cc;



    void Start()
    {
      //  GameObject Player = GameObject.Find("PrototypePlayer");
      //  cc = Player.GetComponent<CharacterController>();
        
        
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        
      
        if (other.tag == "Dummy" && interacting)
        {
            Debug.Log("can Interact with this guy AND you are interacting");
            cc.money--;
            interacting = false;

        }

    }


    }
