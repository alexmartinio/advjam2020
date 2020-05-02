using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToEnable;
    [SerializeField] private List<float> objectsToEnableDelay;
    [SerializeField] private List<GameObject> objectsToDisable;
    [SerializeField] private List<float> objectsToDisableDelay;

    public void Execute()
    {
        StartCoroutine(Enable());
    }

    IEnumerator Enable()
    {
        for (int i = 0; i < objectsToEnable.Count; i++)
        {
            yield return new WaitForSeconds(objectsToEnableDelay[i]);
            objectsToEnable[i].SetActive(true);
        }
        StartCoroutine(Disable());
    }

    IEnumerator Disable()
    {
        for (int i = 0; i < objectsToDisable.Count; i++)
        {
            yield return new WaitForSeconds(objectsToDisableDelay[i]);
            objectsToDisable[i].SetActive(false);
        }
        this.gameObject.SetActive(false);
    }
}
