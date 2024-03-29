using UnityEngine;

public class DialogueActivater : MonoBehaviour, IInteractable
{
    [SerializeField] private DialogueObject dialogueObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
            player.Interactable = this;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
            if(player.Interactable is DialogueActivater dialogueActivater && dialogueActivater == this)
            {
                player.Interactable = null;
            }
        }
    }


    public void Interact(Player player)
    {
        player.DialogueUI.ShowDialogue(dialogueObject);
    }
}
