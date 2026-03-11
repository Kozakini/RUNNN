using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIController : MonoBehaviour
{
    public Transform target;

    public float rotationSpeed = 3f;

    private Quaternion lookRotation;

    private Vector3 directionTarget;
    private Vector3 movement;

    private Renderer colored;
    public int speed = 1;
    public Rigidbody rb;

    private NavMeshAgent agent;
    void Start()
    {
        colored = GetComponent<Renderer>();
        agent = GetComponent<NavMeshAgent>();
        colored.material.color = Color.red;

        
    }

    void Update()
    {
      agent.SetDestination(target.position);

    }
}
