using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;  // 정확한 네임스페이스 사용

public class Controller : MonoBehaviour
{
    public NavMeshAgent agent;  // NavMeshAgent 컴포넌트 참조

    // Start is called before the first frame update
    void Start()
    {
        // 게임 시작 시 (0, 0, 0) 위치로 이동 설정
        agent.SetDestination(new Vector3(0, 0, 0));
    }
}
