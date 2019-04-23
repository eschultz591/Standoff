using UnityEngine;
using System.Collections;

public class Staircase : MonoBehaviour
{
    public string layerName1;

    public string layerName2;

    private int layer1, layer2;

    private Camera mainCamera;


    void Start()
    {
        mainCamera = Camera.main;

        layer1 = LayerMask.NameToLayer(layerName1);
        layer2 = LayerMask.NameToLayer(layerName2);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
     
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("here");
            int currentFloorLayer = other.gameObject.layer;

            if (currentFloorLayer == layer1 || currentFloorLayer == layer2)
            {
                ToggleLayer(LayerMask.LayerToName(layer1));

                ToggleLayer(LayerMask.LayerToName(layer2));

                other.gameObject.layer = (currentFloorLayer == layer1) ? layer2 : layer1;

                foreach (Transform child in other.GetComponentsInChildren<Transform>(true))
                {
                    child.gameObject.layer = (currentFloorLayer == layer1) ? layer2 : layer1; 
                }
            }
        }
    }


    private void ToggleLayer(string layerName)
    {
        mainCamera.cullingMask ^= 1 << LayerMask.NameToLayer(layerName);
    }



   

}

/*
public static void ChangeLayersRecursively(this Transform trans, string name)
{
    trans.gameObject.layer = LayerMask.NameToLayer(name);
    foreach (Transform child in trans)
    {
        child.ChangeLayersRecursively(child, name);
    }
}*/