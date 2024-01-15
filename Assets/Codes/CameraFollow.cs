using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = player.transform.position + new Vector3(0, 0, -5);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.1f);
    }
}
