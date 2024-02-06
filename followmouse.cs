using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followmouse : MonoBehaviour
{
    void Update()
    {
        // 현재 마우스 위치를 가져옵니다.
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // 카메라와의 거리를 조절합니다.

        // 오브젝트 위치를 마우스 위치로 설정합니다.
        transform.position = mousePosition;
    }
}