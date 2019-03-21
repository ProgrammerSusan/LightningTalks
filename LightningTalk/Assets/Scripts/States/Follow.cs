using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : PersonState
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Ray ray = new Ray(animator.transform.position, animator.transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo,50))
        {
            float distance = Vector3.Distance(animator.transform.position, hitInfo.transform.position);
            if (distance < 3f)
            {
                animator.SetBool("Lost", true);
            }
            else
            {
                setDestination(hitInfo.transform.position);
            }
        }
        else
        {
            animator.SetBool("Lost", true);
        }
    }
}
