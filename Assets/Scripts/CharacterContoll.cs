using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterControll : MonoBehaviour
{
    //[SerializeField] private Transform positionTarget;

    private NavMeshAgent navMeshAgent;

 
    // Start is called before the first frame update
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        //navMeshAgent.destination = positionTarget.position;
        if (Input.GetMouseButtonDown(1))
        {
            
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                //navMeshAgent.destination = hit.point;
                navMeshAgent.SetDestination(hit.point);
            }
        }
    }
}