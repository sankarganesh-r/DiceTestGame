using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    Animator animator;
    public string[] animationTriggers;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public IEnumerator AnimationLandedTrigger(int diceValue, Action onComplete){
        animator.SetTrigger("Rolling");
        yield return new WaitForSeconds(1f);
        animator.SetTrigger(animationTriggers[diceValue-1]);
        yield return new WaitForSeconds(1f);
        onComplete?.Invoke();
    }
}
