using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINPC : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("TargetUpdate", 0, 0.727f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TargetUpdate() {
        agent.SetDestination(target.position);
    }
}
