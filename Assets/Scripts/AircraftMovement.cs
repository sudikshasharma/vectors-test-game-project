using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AircraftMovement : MonoBehaviour
{
    public float rotationSpeed = 15f;
    public float movementSpeed = 15f;
    float rotatex = 0;
    float rotatey = 0;
    float rotatez = 0;
    float movement = 0;
    void Update()
    {
        rotatex = Input.GetAxis("RotateX") * rotationSpeed;
        rotatey = Input.GetAxis("Horizontal") * rotationSpeed;
        rotatez = Input.GetAxis("RotateZ") * rotationSpeed;
        movement = Input.GetAxis("Vertical") * movementSpeed;
        rotatex *= Time.deltaTime;
        rotatey *= Time.deltaTime;
        rotatez *= Time.deltaTime;
        movement *= Time.deltaTime;
        transform.Translate(new Vector3(0, 0, movement));
        transform.Rotate(new Vector3(rotatex, 0, 0));
        transform.Rotate(new Vector3(0, rotatey, 0));
        transform.Rotate(new Vector3(0, 0, rotatez));
    }
}
