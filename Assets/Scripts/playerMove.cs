using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerMove : MonoBehaviour
{
    private ChangeBackground _ChangeBackground;
    NavMeshAgent agent;
    void Start()
    {
        _ChangeBackground = FindObjectOfType<ChangeBackground>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "white")
        {
            _ChangeBackground.Change(0.05f);
        }
        if (collision.gameObject.tag == "black")
        {
            _ChangeBackground.Change(-0.05f);
        }

    }
}
