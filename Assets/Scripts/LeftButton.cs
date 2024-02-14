using UnityEngine;
using UnityEngine.UI;

public class LeftButton : MonoBehaviour
{
    public PlayerController playerController;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(MoveLeft);
    }

    void MoveLeft()
    {
        playerController.MoveLeft();
    }
}
