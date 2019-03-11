using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardAttack : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;
    [SerializeField]
    private bool destroy = false;
    [SerializeField]
    private float attackCD = .5f;

    public CharacterController characterController;

    /*void Start()
    {
            destroy = false;

}*/
  

    // Update is called once per frame
    void Update()
    {
        if (destroy == true)
        {
            Destroy(gameObject);
        }  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dummy")
        {
            Debug.Log("HIT");
            characterController = other.GetComponent<CharacterController>();
            characterController.TakeDamage(damage);
        }
        else
        {
            Debug.Log("no hit");
        }
        if (other.tag == "Player")
        {
            Debug.Log("Player hit");
        }
                
    }
}
