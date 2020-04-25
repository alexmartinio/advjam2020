using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    SpriteRenderer spriteRender;
    bool change_colour = true;

    Animator animControl;
    private void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
        animControl = gameObject.GetComponent<Animator>();
    }

    /* Function to play animations,
     * Function expects the truggerNane (set in animator control) and a state (true/falls)
     */
    public void Execute(string triggerName, bool state)
    {
        animControl.SetBool(triggerName, state);
    }
}
