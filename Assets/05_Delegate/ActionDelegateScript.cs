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
            // ī�� ����
            Debug.Log("���콺 Ŭ��");
            myDelegate();
        }
    }

    public void CountClick()
    {
        _Count += 1;
        Debug.Log(_Count + "�� Ŭ��");

        if (_Count > 2)
        {
            Debug.Log(_Count + "�� Ŭ���ؼ� �ʱ�ȭ�Ѵ�");
            _Count = 0;
            return;
        }

        if (_Count == 2)
        {
            Debug.Log("2�� Ŭ���ߴ�.");
        }
    }


}
