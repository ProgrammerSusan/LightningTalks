using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PersonState : StateMachineBehaviour
{
    NavMeshAgent agent;
    GameObject person;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        person = animator.gameObject;
        agent = animator.gameObject.GetComponent<NavMeshAgent>();
    }

    protected void setDestination(Vector3 position)
    {
        agent.SetDestination(position);
    }

}
