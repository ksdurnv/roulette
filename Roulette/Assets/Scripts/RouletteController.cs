using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotationSpeed = 0;
    void Start()
    {
        
    }
    void Update()
    {
        //1. ȭ�� ������ ��� ��������?
        bool isLeftDown = Input.GetMouseButtonDown(0);
        bool isRightDown = Input.GetMouseButtonDown(1);
        

        if (isLeftDown)
        {
            rotationSpeed = 10;
            Debug.Log("���� ��ư�� �������ϴ�!");
        }

        if (isRightDown)
        {
            rotationSpeed = -10;
            Debug.Log("������ ��ư�� �������ϴ�!");
        }

        //2. ȸ�� ��� ��Ű��?
        this.transform.Rotate(0, 0, rotationSpeed);

        //�ӵ� ���̰�
        rotationSpeed *= 0.99f;

    }
}
