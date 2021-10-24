using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControler : MonoBehaviour
{
    // ใช้งาน AI ผ่าน NavMeshAgent ของ Unity
    NavMeshAgent agent;
    //เป้าหมายที่ AI จะเดินผ่าน NavMeshAgent
    public GameObject target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();    
       
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
