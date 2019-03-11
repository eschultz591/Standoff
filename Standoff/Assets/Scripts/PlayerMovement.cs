using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;


    public float runSpeed = 40f;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        verticalMove = Input.GetAxis("Vertical") * runSpeed;
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mouseLocation = Input.mousePosition;
            controller.Click(mouseLocation);
        }


    }

    void FixedUpdate()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        controller.Move(verticalMove, horizontalMove,mouse);



    }
}
