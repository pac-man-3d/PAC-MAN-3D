using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour {

    public float targetDistance;

        void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        RaycastHit TheHit;
        if (Physics.Raycast(transform.position,transform.TransformDirection( Vector3.forward), out TheHit))  {
            targetDistance = TheHit.distance;
        }
        Vector3 target = transform.position + Vector3.right * targetDistance;
        agent.SetDestination(target);
    }
}
