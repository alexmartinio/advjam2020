using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialog : MonoBehaviour
{
    // Start is called before the first frame update
    DialogueTrigger dialogueTrigger;
    void Start()
    {
        dialogueTrigger = this.GetComponent<DialogueTrigger>();
        dialogueTrigger.TriggerDialogue();
    }

}
