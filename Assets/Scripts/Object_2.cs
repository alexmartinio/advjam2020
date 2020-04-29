using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_2 : MonoBehaviour
{
    SpriteRenderer spriteRender;
    bool change_colour = true;
    [SerializeField] GameObject objectToEnable;

    Animator animControl;
    private void Start()
    {

    }

    public void Execute()
    {
        objectToEnable.SetActive(true);
        Destroy(gameObject);
    }
}
