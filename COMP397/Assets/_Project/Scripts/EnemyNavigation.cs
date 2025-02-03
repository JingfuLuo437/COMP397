using UnityEngine;
using UnityEngine.AI;

namespace Platformer397
{
    public class EnemyNavigation : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private NavMeshAgent agent;
        private Transform player;
        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            player = GameObject.FindWithTag("Player").transform.transform;
        }
        private void Update()
        {
            
            agent.destination = player.position;
        
        }

        
    }
}
