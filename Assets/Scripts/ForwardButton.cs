using UnityEngine;
using UnityEngine.UI;

public class ForwardButton : MonoBehaviour
{
    public PlayerController playerController;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(MoveForward);
    }

    void MoveForward()
    {
        playerController.MoveForward();
    }
}
