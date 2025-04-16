using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlAnimations : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    public void AnimR()
    {
        animator.SetTrigger("StartAnimR");
    }
    public void AnimL()
    {
        animator.SetTrigger("StartAnimL");
    }
}