using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    RaycastHit2D hitDetection()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        return hit;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = hitDetection();
            if (hit.collider != null)
            {
                if ((hit.collider.gameObject.GetComponent("Object") as Object) != null)
                {
                    hit.collider.gameObject.GetComponent<Object>().Execute();
                }
            }   
        }
    }
}
