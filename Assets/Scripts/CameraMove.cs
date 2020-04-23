using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float dragSpeed = 1;
    private Vector3 dragOrigin;

    public bool cameraDragging = true;


    public GameObject leftLimit;
    public GameObject rightLimit;

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        // Calculate left and right
        float left = Screen.width * 0.2f;
        float right = Screen.width - (Screen.width * 0.2f);

        // Determine if the camera is moving
        if (mousePosition.x < left)
        {
            cameraDragging = true;
        }
        else if (mousePosition.x > right)
        {
            cameraDragging = true;
        }

        if (cameraDragging)
        {
            // If left mouse btn is pressed
            // take mouse position
            if (Input.GetMouseButtonDown(0))
            {
                dragOrigin = Input.mousePosition;
                return;
            }

            // If mouse is let go exit function
            if (!Input.GetMouseButton(0)) return;

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            Vector3 move = new Vector3(pos.x * dragSpeed, 0, 0);

            // Which way to move
            if (move.x > 0f)
            {
                if (this.transform.position.x < rightLimit.transform.position.x)
                {
                    // invert move to follow in same direction
                    transform.Translate(move, Space.World);
                }
            }
            else
            {
                if (this.transform.position.x > leftLimit.transform.position.x)
                {
                    transform.Translate(move, Space.World);
                }
            }
        }
    }
}
