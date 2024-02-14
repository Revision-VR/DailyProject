using UnityEngine;
using UnityEngine.UI;

public class VRButtonActions : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    private Transform cameraTransform;

    private void Start()
    {
        cameraTransform = Camera.main.transform; 
    }

    private void Update()
    {
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

 
        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickUp))
        {
            MoveForward();
        }
        else if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickDown))
        {
            MoveBackward();
        }
        else if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickLeft))
        {
            MoveLeft();
        }
        else if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickRight))
        {
            MoveRight();
        }
    }

    private void MoveForward()
    {
        // Implement your custom action for moving forward
        Debug.Log("Moving Forward");
        transform.position += cameraTransform.forward * movementSpeed * Time.deltaTime;
    }

    private void MoveBackward()
    {
        // Implement your custom action for moving backward
        Debug.Log("Moving Backward");
        transform.position -= cameraTransform.forward * movementSpeed * Time.deltaTime;
    }

    private void MoveLeft()
    {
        // Implement your custom action for moving left
        Debug.Log("Moving Left");
        transform.position -= cameraTransform.right * movementSpeed * Time.deltaTime;
    }

    private void MoveRight()
    {
        // Implement your custom action for moving right
        Debug.Log("Moving Right");
        transform.position += cameraTransform.right * movementSpeed * Time.deltaTime;
    }
}
