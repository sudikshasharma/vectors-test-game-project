using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Move : MonoBehaviour
{
    void Update()
    {
        Vector2 pos = this.transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += 0.1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= 0.1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.1f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 0.1f;
        }
        this.transform.position = pos;
    }
}
