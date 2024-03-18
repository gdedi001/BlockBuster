using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public float speed = 2.5f;
    //public GameObject CameraRig;
    //private Vector3 moveDirection = transform.forward; // Moving along the Z-axis

    void Update()
    {
        // Move the cube in the specified direction at the speed defined
        //transform.position += speed * Time.deltaTime * transform.forward;
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
