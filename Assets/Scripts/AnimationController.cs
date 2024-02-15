using System.Collections;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator FizikaAnimator;

    private int Count = 0;
    private bool isAnimationPlaying = false;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftControler(Count);
            Count++;
        }
        else if (!isAnimationPlaying && Input.GetKeyDown(KeyCode.S))
        {
            RightControler(Count);
            Count++;
        }

    }

    public void LeftControler(int a)
    {

        if (a % 2 == 0)
        {
            FizikaAnimator.SetInteger("Fizika", 3);
            StartCoroutine(kutish());
        }
        else if (a % 2 != 0)
        {
            FizikaAnimator.SetInteger("Fizika", 2);
            StartCoroutine(kutish());
        }

    }
    public void RightControler(int a)
    {
        if (a % 2 == 0)
        {
            FizikaAnimator.SetInteger("Fizika", 1);
            //StartCoroutine(kutish());
        }
        else if (a % 2 != 0)
        {
            FizikaAnimator.SetInteger("Fizika", 4);
            //StartCoroutine(kutish());
        }

        isAnimationPlaying = true;

        StartCoroutine(kutish());
    }

    IEnumerator kutish()
    {
        yield return new WaitForSeconds(1);
        FizikaAnimator.SetInteger("Fizika", 5);
        isAnimationPlaying = false;
    }




}