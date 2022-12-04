using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody myBody;
    public float speed = 400f;
    public Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement(){
        float hMove = Input.GetAxis("Horizontal") * Time.deltaTime * 2f;
        float vMove = Input.GetAxis("Vertical") * Time.deltaTime * 2f;

        Vector3 verCam = mainCam.transform.forward;
        Vector3 horCam = mainCam.transform.right;

        verCam.y = 0f;
        horCam.y = 0f;

        verCam.Normalize();
        horCam.Normalize();


        Vector3 playerMove = (verCam * vMove + horCam * hMove) * speed;

        myBody.AddForce(playerMove);
    }
}
