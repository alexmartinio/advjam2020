using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreditsFontSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject headingTemplate = GameObject.Find("Headingg");

        GetComponent<TMP_Text>().fontSize = headingTemplate.GetComponent<TMP_Text>().fontSize;
        Debug.Log(GetComponent<TMP_Text>().fontSize);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
