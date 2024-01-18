using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

<<<<<<< HEAD
=======
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);

    }

    // Update is called once per frame
>>>>>>> f28b1fe6188bb3be9d09d80d47c10061b10cec10
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
