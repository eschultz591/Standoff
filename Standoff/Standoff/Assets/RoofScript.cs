
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoofScript : MonoBehaviour
{
    // Roof tiles render
    private SpriteRenderer spriteRenderer;


    // Use this for initialization
    void Start()
    {
        // Get the roof's mesh render
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Inside the building
    void OnTriggerEnter2D(Collider2D other)
    {

        // Get player
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("here");

            // Hide roof
            spriteRenderer.enabled = false;
        }
    }


    // Outside the building
    void OnTriggerExit2D(Collider2D other)
    {
        // Show roof
        spriteRenderer.enabled = true;
    }
}

