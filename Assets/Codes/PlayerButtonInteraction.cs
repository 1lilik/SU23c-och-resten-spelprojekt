using UnityEngine;

public class PlayerButtonInteraction : MonoBehaviour
{
    public KeyCode interactionKey = KeyCode.E;
    public float interactionDistance = 1.5f;
    public LayerMask buttonLayer;

    void Update()
    {
        if (Input.GetKeyDown(interactionKey))
        {
            TryInteractWithButtons();
        }
    }

    void TryInteractWithButtons()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, interactionDistance, buttonLayer);

        foreach (Collider2D collider in colliders)
        {
            ButtonInteraction buttonInteraction = collider.GetComponent<ButtonInteraction>();

            if (buttonInteraction != null)
            {
                buttonInteraction.OnButtonPressed();
            }
        }
    }
}
