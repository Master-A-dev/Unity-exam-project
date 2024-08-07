using NavMeshPlus.Extensions;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Transform target;
    public float range = 10;
    float dist;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        target = GameObject.Find(charSheet.player.role.ToString() + "(Clone)").transform;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector2.Distance(transform.position, target.position);
        if (dist < range)
        {
            agent.SetDestination(target.position);
        }
        
    }
}
