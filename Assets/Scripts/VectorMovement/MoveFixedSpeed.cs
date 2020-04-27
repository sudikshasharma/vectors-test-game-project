using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFixedSpeed : MonoBehaviour
{
    public Transform Fuel;
    public float speed;
    private Vector3 pos;
    private Vector3 normal;
    private float stoppingDistance = 10f;
    void Start()
    {
        pos = (Fuel.position - this.transform.position);
        normal.x = pos.x / Mathf.Sqrt((pos.x * pos.x) + (pos.y * pos.y));
        normal.y = pos.y / Mathf.Sqrt((pos.x * pos.x) + (pos.y * pos.y));
        Debug.Log(normal);
    }

    void Update()
    {
        if (Vector3.Distance(Fuel.position, this.transform.position) > stoppingDistance)
            this.transform.position += normal * speed * Time.deltaTime;
    }
}
