using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueManager;

    DialogueManager _dialogueManager;

    private void Start()
    {
        _dialogueManager = dialogueManager.GetComponent<DialogueManager>();
    }
    RaycastHit2D hitDetection()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        return hit;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && _dialogueManager.textPlaying == false)
        {
            RaycastHit2D hit = hitDetection();
            if (hit.collider != null)
            {
                if ((hit.collider.gameObject.GetComponent("Object") as Object) != null)
                {
                    hit.collider.gameObject.GetComponent<Object>().Execute();
                }
                if ((hit.collider.gameObject.GetComponent("DialogueTrigger") as DialogueTrigger) != null)
                {
                    hit.collider.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
            }   
        }
    }
}
