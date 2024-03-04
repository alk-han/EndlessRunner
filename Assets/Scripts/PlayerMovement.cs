using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3.0f;
    [SerializeField] float leftRightSpeed = 4.0f;


    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
            }
        }
    }
}
