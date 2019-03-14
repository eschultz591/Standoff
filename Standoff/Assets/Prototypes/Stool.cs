using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stool
{
    public int stoolNum;
    public bool isTaken;
    public Vector3 stoolLocation;
    public Stool(int seatNum, bool taken, Vector3 spot)
    {
        stoolNum = seatNum;
        isTaken = taken;
        stoolLocation = spot;
    }

}
