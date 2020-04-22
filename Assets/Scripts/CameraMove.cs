using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float delta = 10f; //  Pixels. The width border at the edge in which the movement work
    public float speed = 3.0f; // Scale. Speed of the movement

    public GameObject leftLimit;
    public GameObject rightLimit;

    private Vector3 mRightDirection ; // The inital "right" of the camera

    void Start()
    {
        mRightDirection = transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x >= Screen.width - delta)
        {
            if(transform.position.x <= leftLimit.transform.position.x)
            {
                // Move the camera
                transform.position += mRightDirection * Time.deltaTime * speed;
            }
            
        }

        if (Input.mousePosition.x <= 0 + delta)
        {
            if(transform.position.x >= rightLimit.transform.position.x)
            {
                // Move the camera
                transform.position -= mRightDirection * Time.deltaTime * speed;
            }

        }

    }
}
