using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followmouse : MonoBehaviour
{
    void Update()
    {
        // ���� ���콺 ��ġ�� �����ɴϴ�.
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // ī�޶���� �Ÿ��� �����մϴ�.

        // ������Ʈ ��ġ�� ���콺 ��ġ�� �����մϴ�.
        transform.position = mousePosition;
    }
}