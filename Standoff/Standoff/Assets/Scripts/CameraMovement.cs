using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
  
    public GameObject player;       

    //private Vector2 offset;
    private Vector3 offset = new Vector3(0,0,-2);         


    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        ///delete the bottom comment once you set up the code for camera lag
       // offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
       //Vector2 pV2 = Vector3Extension.AsVector2(player.transform.position);
        transform.position = player.transform.position + offset;
    }



  
}
/*
public static class Vector3Extension
{
    public static Vector2 AsVector2(this Vector3 _v)
    {
        return new Vector2(_v.x, _v.y);
    }
}

    */
