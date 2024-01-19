using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public float typingSpeed = 0.05f;

    private List<string> dialogueData = new List<string>
    {
        "Dorian: I need to pack some essentials before we leave.",
        "Dorian: My family is waiting for me. I need to hurry. ",
    };

    private int currentLineIndex = 0;
    private string currentLine = "";

    void Start()
    {
        // Start displaying dialogue
        StartCoroutine(TypeDialogue());
    }

    IEnumerator TypeDialogue()
    {
        foreach (char letter in dialogueData[currentLineIndex].ToCharArray())
        {
            currentLine += letter;
            dialogueText.text = currentLine;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void Update()
    {
        // Check for user input to move to the next line or end the dialogue
        if (Input.GetMouseButtonDown(0))  // Change this to your preferred input method
        {
            currentLineIndex++;

            if (currentLineIndex < dialogueData.Count)
            {
                currentLine = "";
                StartCoroutine(TypeDialogue());
            }
            else
            {
                // End dialogue or do something else
                Debug.Log("End of dialogue");
            }
        }
    }
}
