using UnityEngine;

public class VRButtonMovement : MonoBehaviour
{
    public float movementSpeed = 1.0f;

    private Transform cameraTransform;

    Vector3 forward;
    Vector3 right;
    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        forward = cameraTransform.forward;
        right = cameraTransform.right;


        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();
        ClickForward();
        ClickLeft();
        ClicRight();


        //if (Input.GetButtonDown("Forward"))
        //{
        //    transform.position += forward * movementSpeed * Time.deltaTime;
        //}
        //else if (Input.GetButtonDown("Backward"))
        //{
        //    transform.position -= forward * movementSpeed * Time.deltaTime;
        //}
        //else if (Input.GetButtonDown("Left"))
        //{
        //    transform.position -= right * movementSpeed * Time.deltaTime;
        //}
        //else if (Input.GetButtonDown("Right"))
        //{
        //    transform.position += right * movementSpeed * Time.deltaTime;
        //}
    }

    public void ClickForward()
    {
        transform.position += forward * movementSpeed * Time.deltaTime;
    }
    public void ClickLeft()
    {
        transform.position -= right * movementSpeed * Time.deltaTime;
    }
    public void ClicRight()
    {
        transform.position += right * movementSpeed * Time.deltaTime;
    }

}
