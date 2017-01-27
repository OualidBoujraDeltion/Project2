using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Camera mainCamera;
    public float moveSpeed;
    public float turnSpeed;

    void Update()
    {
        
        Vector3 nextDirection = gameObject.transform.position;
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        nextDirection += mainCamera.transform.right * horizontalMovement * moveSpeed * Time.deltaTime;
        nextDirection += mainCamera.transform.forward * verticalMovement * moveSpeed * Time.deltaTime;

        gameObject.transform.localPosition = nextDirection;
                
        Vector3 lookDirection = mainCamera.transform.localEulerAngles;
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        lookDirection.x -= verticalRotation * turnSpeed * Time.deltaTime;
        lookDirection.y += horizontalRotation * turnSpeed * Time.deltaTime;

        mainCamera.transform.localEulerAngles = lookDirection;
    }
}