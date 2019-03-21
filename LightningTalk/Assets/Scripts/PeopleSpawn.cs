using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawn : MonoBehaviour
{
    public GameObject person;
    private Vector3 pos;

    // Use this for initialization
    void Start()
    {
        for(int i = 0; i < 200; i++)
        {
            pos.x = Random.Range(-45, 45);
            pos.y = 1;
            pos.z = Random.Range(-45, 45);

            GameObject.Instantiate(person, pos, person.transform.rotation);
        }
        
    }
}
