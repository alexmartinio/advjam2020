using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidersToEnable : MonoBehaviour
{
    [SerializeField] List<GameObject> boxColidersToEnable;
    // Start is called before the first frame update

    public void EnableColliders()
    {
        if (boxColidersToEnable.Count != 0)
        {
            foreach (GameObject item in boxColidersToEnable)
            {
                item.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }

}
