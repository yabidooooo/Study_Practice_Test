using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ref Ű���带 �Ű����� �տ� �ٿ���� Swap()�� ����� ����ȴ�.
// ref Ű���尡 ������ 3,4�� 2�� ������.
// ref Ű���尡 �־�� 3,4 �� 4,3 ���� �������´�.
public class SwapByRef : MonoBehaviour
{
    void Start()
    {
        Main();
    }

    void Main()
    {
        int x = 3;
        int y = 4;

        Debug.Log($"x:{x}, y:{y}");

        Swap(ref x, ref y);

        Debug.Log($"x:{x}, y:{y}");
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = b;
        b = a;
        a = temp;
    }

}

