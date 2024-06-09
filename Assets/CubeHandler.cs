using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHandler : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print(string.Format("{0} ������Ʈ�� {1} �� �浹�߽��ϴ�.", gameObject.name, other.gameObject.name));
    }

    private void OnTriggerExit(Collider other)
    {
        print(string.Format("{0} ������Ʈ�� {1} �� ���������ϴ�.", gameObject.name, other.gameObject.name));
    }
}