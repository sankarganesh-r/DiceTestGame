using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    Animator animator;
    public string[] animationTriggers;
    int diceValue;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimationTrigger(int diceValue){
        this.diceValue=diceValue;
        animator.SetTrigger("Rolling");
        StartCoroutine(AnimationLandedTrigger());
    }

    IEnumerator AnimationLandedTrigger(){

        yield return new WaitForSeconds(1f);
        animator.SetTrigger(animationTriggers[diceValue-1]);

    }
}
