using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset;
    [SerializeField] private GameObject player;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        if (player)
        {
            transform.position = player.transform.position + offset;
            
        }        
    }
}
