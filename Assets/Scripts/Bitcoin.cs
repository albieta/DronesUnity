using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitcoin : MonoBehaviour
{
    public AnimationCurve myCurve;

    private float posX = 0;
    private float posZ = 0;

    void Start()
    {
        posX = transform.position.x;
        posZ = transform.position.z;
    }

    void Update()
    {
        transform.position = new Vector3(posX, myCurve.Evaluate((Time.time % myCurve.length)), posZ);
    }

    void OnCollisionEnter(Collision collision)
    {
        Aircraft1 otherAircraft = collision.gameObject.GetComponent<Aircraft1>();

        if (otherAircraft != null)
        {
            otherAircraft.coins += 1;
            Destroy(gameObject);
        }
    }
}
