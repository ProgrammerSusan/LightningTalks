using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : PersonState
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
        if(Physics.Raycast(ray, out hitInfo))
        {
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            if (hitInfo.transform.CompareTag("Building"))
            {
                animator.SetBool("Found", true);
            }
            else if (hitInfo.transform.CompareTag("Door"))
            {
                animator.SetBool("Found", true);
            }
            else if (hitInfo.transform.CompareTag("Person"))
            {
                Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
                float distance = Vector3.Distance(animator.transform.position, hitInfo.transform.position);
                if(distance > 10f)
                {
                    animator.SetBool("Following", true);
                }
            }
            else
            {
                animator.SetBool("NotFound", true);
            }
        }
        else
        {
            animator.SetBool("NotFound", true);
        }
    }
}
