using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour {

    private GameObject wayPoint;
    private NavMeshAgent agent;
    
    // Use this for initialization
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        wayPoint = GameObject.FindGameObjectWithTag("WayPoint");
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnEnable()
    {
        NewNavMeshAgentPoint(wayPoint.GetComponent<Transform>().position);
    }

    public void NewNavMeshAgentPoint(Vector3 destinationPoint)
    {
        agent.destination = destinationPoint;
        agent.Resume();
    }
}
