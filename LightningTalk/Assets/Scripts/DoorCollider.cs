using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
{
    public GameObject target;

    void OnCollisionEnter(Collision coll)
    {
        target = coll.gameObject;
        if (target.transform.CompareTag("Person"))
        {
            Destroy(target);
        }
    }
}
