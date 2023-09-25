using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft1 : MonoBehaviour
{
    public AnimationCurve myCurve;
    public GameObject aircraftObject;
    public int coins = 0;

    void Update()
    {
        if (aircraftObject != null)
        {
           // aircraftObject.transform.position = new Vector3(aircraftObject.transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), aircraftObject.transform.position.z);
        }
    }
}
