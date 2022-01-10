using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    [SerializeField] private Transform[] Points;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        var destP = Points[Random.Range(0, Points.Length)];
        if (!agent.pathPending && agent.remainingDistance <= 0.5f)
        {
            agent.destination = destP.position;
            Debug.Log(destP.name);
        }
        
    }
}
