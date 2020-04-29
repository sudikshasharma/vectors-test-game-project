using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DotAndCrossProductAngle : MonoBehaviour
{
    public Transform Fuel;
    public float speed;
    private float stoppingDistance = 10f;
    Vector3 fuelLoc;
    void Start()
    {
        CalculateAndTurnTank();
    }

    void Update()
    {
        CalculateAndTurnTank();
        fuelLoc = (transform.position - Fuel.position).normalized;
        if (Vector3.Distance(Fuel.position, this.transform.position) > stoppingDistance)
        {
            this.transform.position += fuelLoc * -speed * Time.deltaTime;
        }
    }

    void CalculateAndTurnTank()
    {
        //Tank upward direction vector
        Vector3 upward = this.transform.up;
        //Tank to fuel vector(normalized)
        Vector3 fuelVec = (Fuel.transform.position - this.transform.position).normalized;

        //Angle through dot product
        float angle = Mathf.Acos((upward.x * fuelVec.x + upward.y * fuelVec.y) / upward.magnitude * fuelVec.magnitude);
        Debug.Log("Angle between upward tank direction and fuel (in degree) : " + angle * 180 / Mathf.PI);

        //Finding for rotation direction (through z axis evaluation by cross product)
        Vector3 crossProduct = new Vector3(upward.y * fuelVec.z - upward.z * fuelVec.y, upward.z * fuelVec.x - upward.x * fuelVec.z, upward.x * fuelVec.y - upward.y * fuelVec.x);
        if (crossProduct.z < 0)// If clockwise(Right Handed rotation)
        {
            angle = 2 * Mathf.PI - angle;
        }

        //Rotating tank with respect to its upward vector(using formula to move a point around a circle with given angle)
        this.transform.up = new Vector3(upward.x * Mathf.Cos(angle) - upward.y * Mathf.Sin(angle), upward.x * Mathf.Sin(angle) + upward.y * Mathf.Cos(angle));

    }
}
