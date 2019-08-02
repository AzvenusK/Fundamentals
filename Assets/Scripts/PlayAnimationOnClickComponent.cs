using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnClickComponent : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.Play("cubeAnim");
;        }
    }
}
