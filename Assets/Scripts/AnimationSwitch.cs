using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    [SerializeField] private GameObject objectToActivate;
    // Start is called before the first frame update

    Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void AnimationFinished()
    {
        objectToActivate.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
