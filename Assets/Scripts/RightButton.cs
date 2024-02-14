using UnityEngine;
using UnityEngine.UI;

public class RightButton : MonoBehaviour
{
    public PlayerController playerController;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(MoveRight);
    }

    void MoveRight()
    {
        playerController.MoveRight();
    }
}
