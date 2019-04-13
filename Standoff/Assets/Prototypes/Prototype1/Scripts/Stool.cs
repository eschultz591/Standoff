using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stool 
{
    public int stoolNum;
    public bool isTaken;
    public Transform stoolTransform;
    public Vector3 stoolV3;
    public GameObject patron;

    public Stool(int seatNum, bool taken, Transform spot, Vector3 v3, GameObject p)
    {
        stoolNum = seatNum;
        isTaken = taken;
        stoolTransform = spot;
        stoolV3 = v3;
        patron = p;
    }


}
