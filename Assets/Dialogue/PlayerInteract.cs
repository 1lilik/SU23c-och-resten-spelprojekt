using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;
    public DialogueUI DialogueUI => dialogueUI;

    public IInteractable Interactable { get; set; }
    
    void Update()
    {
        if (dialogueUI.IsOpen) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
           
            Interactable?.Interact(player: this);
        
        }
    }
}
