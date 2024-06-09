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
    if (agent == null)
    {
        Debug.LogError("NavMeshAgent component is not attached to " + gameObject.name);
        return;
    }

    // 게임 시작 시 (42, 1, 394) 위치로 이동 설정
    agent.SetDestination(new Vector3(2, 7, 0));
    // agent.SetDestination(new Vector3(43, 1, 380));
}
}
