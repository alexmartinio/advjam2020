using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] List<GameObject> objectsToEnable;
    [SerializeField] List<float> objectsToEnableDelay;
    [SerializeField] List<GameObject> objectsToDisable;
    [SerializeField] List<float> objectsToDisableDelay;

    [SerializeField] List<GameObject> boxColidersToEnable;
    [SerializeField] bool playAudioOnWake;

    AudioSource _audio;
    private void Start()
    {
        _audio = this.gameObject.GetComponent<AudioSource>();
    }

    public void Execute()
    {
        StartCoroutine(Enable());
    }

    IEnumerator Enable()
    {
        if(objectsToEnable.Count != 0)
        {
            for (int i = 0; i < objectsToEnable.Count; i++)
            {
                if(objectsToEnableDelay.Count != 0)
                {
                    yield return new WaitForSeconds(objectsToEnableDelay[i]);
                    
                }
                else
                {
                    yield return new WaitForSeconds(0f);
                }
                objectsToEnable[i].SetActive(true);
                if(playAudioOnWake)
                {
                    objectsToEnable[i].GetComponent<AudioSource>().Play();
                }
            }
            StartCoroutine(Disable());
        }

        if(boxColidersToEnable.Count != 0)
        {
            foreach(GameObject item in boxColidersToEnable)
            {
                item.SetActive(true);
            }    
        }
    }

    IEnumerator Disable()
    {
        if(objectsToDisable.Count != 0)
        {
            for (int i = 0; i < objectsToDisable.Count; i++)
            {
                if(objectsToDisableDelay.Count != 0)
                {
                    yield return new WaitForSeconds(objectsToDisableDelay[i]);
                }
                else
                {
                    yield return new WaitForSeconds(0f);
                }

                objectsToDisable[i].SetActive(false);
            }
        }

        this.gameObject.SetActive(false);
    }
}
