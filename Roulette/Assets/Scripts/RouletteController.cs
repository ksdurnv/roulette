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
        //1. 화면 누르면 어떻게 감지하지?
        bool isLeftDown = Input.GetMouseButtonDown(0);
        bool isRightDown = Input.GetMouseButtonDown(1);
        

        if (isLeftDown)
        {
            rotationSpeed = 10;
            Debug.Log("왼쪽 버튼을 눌렀습니다!");
        }

        if (isRightDown)
        {
            rotationSpeed = -10;
            Debug.Log("오른쪽 버튼을 눌렀습니다!");
        }

        //2. 회전 어떻게 시키지?
        this.transform.Rotate(0, 0, rotationSpeed);

        //속도 줄이고
        rotationSpeed *= 0.99f;

    }
}
