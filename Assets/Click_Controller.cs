using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Click_Controller : MonoBehaviour
{
    public NavMeshAgent agent;  // NavMeshAgent 컴포넌트 참조

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))  // 마우스 오른쪽 버튼 입력 검사
        {
            Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(movePosition, out var hitInfo))  // Raycast 오타 수정
            {
                agent.SetDestination(hitInfo.point);  // 목적지 설정
            }
        }
    }
}