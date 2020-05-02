using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    private Vector3 dialoguePosition;
    public Animator animator;
    public GameObject dialogueBox;
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public bool dialogueFinished = false;


    void Start()
    {
        sentences = new Queue<string>();

        dialogueBox = GameObject.Find("DialogueBox");
        dialoguePosition = dialogueBox.gameObject.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        // Set focus on dialogue box
        EventSystem.current.SetSelectedGameObject(this.gameObject);

        // Move dialogue box into position
        dialoguePosition.y = 75f;
        dialogueBox.transform.position = dialoguePosition;

        // Activate animation
        animator.SetBool("IsOpen", true);
        
        // Set up dialogue text
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        else
        {
            string sentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char character in sentence.ToCharArray())
        {
            dialogueText.text += character;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        dialogueFinished = true;
    }
}
