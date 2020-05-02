using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialog : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject dialogueManager;
    // Start is called before the first frame update
    DialogueTrigger _dialogueTrigger;
    DialogueManager _dialogueManager;

    void Start()
    {
        _dialogueTrigger = this.GetComponent<DialogueTrigger>();
        _dialogueManager = dialogueManager.GetComponent<DialogueManager>();
        _dialogueTrigger.TriggerDialogue();
    }

    private void Update()
    {
        if(_dialogueManager.dialogueFinished)
        {
            objectToActivate.SetActive(true);
            this.gameObject.SetActive(false);
        }    
    }
}
