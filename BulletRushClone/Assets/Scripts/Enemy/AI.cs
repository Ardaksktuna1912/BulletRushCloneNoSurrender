using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
