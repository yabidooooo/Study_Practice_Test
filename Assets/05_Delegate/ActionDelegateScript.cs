using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDelegateScript : MonoBehaviour
{
    public delegate void MyDelegate();
    MyDelegate myDelegate;

    int _Count;

    void Start()
    {
        _Count = 0;
        myDelegate += CountClick;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 카드 선택
            Debug.Log("마우스 클릭");
            myDelegate();
        }
    }

    public void CountClick()
    {
        _Count += 1;
        Debug.Log(_Count + "번 클릭");

        if (_Count > 2)
        {
            Debug.Log(_Count + "번 클릭해서 초기화한다");
            _Count = 0;
            return;
        }

        if (_Count == 2)
        {
            Debug.Log("2번 클릭했다.");
        }
    }


}
