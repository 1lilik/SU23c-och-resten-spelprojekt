using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    Vector3 velocity;

    
    void Start()
    {

    }

    
    void FixedUpdate()
    {
        Vector3 targetPosition = player.transform.position + new Vector3 (0, 0, -5);

        transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, 0.1f);
    }
}
