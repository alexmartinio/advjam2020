using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    [SerializeField] List<GameObject> objectsToActivate;
    [SerializeField] List<GameObject> objectsToDisable;

    [SerializeField] GameObject triggerObject;
    // Start is called before the first frame update

    Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void AnimationFinished()
    {
        if(objectsToActivate.Count != 0)
        {
            foreach (GameObject item in objectsToActivate)
            {
                item.SetActive(true);
            }
        }

        if(objectsToDisable.Count != 0)
        {
            foreach(GameObject item in objectsToDisable)
            {
                item.SetActive(false);
            }
        }
        
        this.gameObject.SetActive(false);
    }

    public void StartleCat()
    {
        if(objectsToActivate.Count != 0 && triggerObject)
        {
            foreach(GameObject item in objectsToActivate)
            {
                if(triggerObject.activeSelf)
                {
                    item.SetActive(true);
                }
            }
        }

        if(objectsToDisable.Count != 0 && triggerObject)
        {
            foreach(GameObject item in objectsToDisable)
            {
                if(triggerObject.activeSelf)
                {
                    item.SetActive(false);
                }
            }
        }
    }
}
