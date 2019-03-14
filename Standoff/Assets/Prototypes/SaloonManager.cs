using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaloonManager : MonoBehaviour
{
    [SerializeField] private List<Stool> Stools = new List<Stool>();
   


    void Start()
    {
        int i = 0;
        foreach (Transform child in (this.transform.parent).transform)
        {
            if (child.tag == "Stool")
            {
                Stools.Add(new Stool(i, false, child.gameObject.transform.position));
                i++;
            }
          
        }
    }

    void Update()
    {
        
    }
}
