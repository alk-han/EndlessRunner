using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 1.0f;


    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed, Space.World);
    }
}
