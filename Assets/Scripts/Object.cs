using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    SpriteRenderer spriteRender;
    bool change_colour = true;
    private void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
    }
    public void Execute()
    {
        if (change_colour)
        {
            spriteRender.color = new Color(1, 0, 0, 1);
            change_colour = false;
        }
        else
        {
            spriteRender.color = new Color(1, 1, 1, 1);
            change_colour = true;
        }
    }
}
