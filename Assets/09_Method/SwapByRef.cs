using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ref 키워드를 매개변수 앞에 붙여줘야 Swap()이 제대로 실행된다.
// ref 키워드가 없으면 3,4로 2번 찍힌다.
// ref 키워드가 있어야 3,4 와 4,3 으로 찍혀나온다.
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

