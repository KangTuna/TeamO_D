using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody pRigidbody;
    float jumpForce = 5.0f;
    bool grounded = false;

    void Start()
    {
        pRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Jump();
        // CheckGround();
        // Vector3 vec = new Vector3(Input.GetAxis("Horizontal") / 7,
        //     Input.GetAxis("Jump"), Input.GetAxis("Vertical") / 7); 
        // transform.Translate(vec); 
    }
     private void Jump()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            //Sqrt 는 빠른 속도로 점프 하고 천천히 낙하하는 부자연스러움을 줄여줌
            Vector3 jumpVelocity = Vector3.up * Mathf.Sqrt(jumpForce * -Physics.gravity.y);

            pRigidbody.AddForce(jumpVelocity, ForceMode.Impulse);
        }
    }
   
    //플레이어 바닥과 충돌 체크
    // private void CheckGround()
    // {
    //     RaycastHit hit;
    //     if (Physics.Raycast(pTransform.position, Vector3.down, out hit, 0.1f))
    //     {
    //         if (hit.transform.tag !=null)
    //         {
    //             grounded = true;
    //             return;
    //         }
    //     }
    //     grounded = false;
    // }
}