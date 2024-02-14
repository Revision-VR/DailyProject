using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
           MoveRight();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
           MoveForward();
        }
    }

    public void MoveLeft()
    {
        transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
    }

    public void MoveRight()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    //public void MoveBackward()
    //{
    //    transform.Translate(Vector3.back * speed * Time.deltaTime);
    //}
}
