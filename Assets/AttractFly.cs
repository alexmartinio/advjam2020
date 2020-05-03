using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractFly : MonoBehaviour
{
    [SerializeField] GameObject flyInside;
    [SerializeField] GameObject toActivate;
    [SerializeField] GameObject toDisable;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(flyInside.activeSelf)
        {
            toActivate.SetActive(true);
            toDisable.SetActive(false);
        }
    }
}
