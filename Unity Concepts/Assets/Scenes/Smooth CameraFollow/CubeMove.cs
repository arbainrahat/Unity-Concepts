using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed = 4f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position += transform.right*(Time.deltaTime*speed);     //transform.right.......Only move right()
        }
        else if (Input.GetKey("a"))
        {
            transform.position += Vector3.left*(Time.deltaTime * speed);
        }
    }
}
