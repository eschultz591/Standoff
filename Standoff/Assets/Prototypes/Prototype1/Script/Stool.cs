using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stool 
{
    public int stoolNum;
    public bool isTaken;
    public Transform stoolTransform;


    public Stool(int seatNum, bool taken, Transform spot)
    {
        stoolNum = seatNum;
        isTaken = taken;
        stoolTransform = spot;
    }


}
