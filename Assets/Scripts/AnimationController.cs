using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator FizikaAnimator;
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)) 
        {
            Left();
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            Right();
        }
    }

    public void Left()
    {
        FizikaAnimator.SetInteger("Fizika", 1);
    }

    public void Right()
    {
        FizikaAnimator.SetInteger("Fizika", 2);
        FizikaAnimator.SetInteger("Fizika", 3);
    }
}
