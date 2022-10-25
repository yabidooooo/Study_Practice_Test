using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUpdateScheduler : Singleton<TestUpdateScheduler>
{
    List<Action> objectList = new List<Action>();
    int FrameCount = 0;

    // �����췯 �����ֱ�
    public void Update()
    {
        Debug.Log("������Ʈ ����");
    }

    // �����췯
    public void OnUpdateScheduler(int frame, Action action)
    {
        FrameCount += 1;
        if (FrameCount % frame == 0)
        {
            action();
            FrameCount = 0;
        }
    }

    // ���� ���
    public void RegisterObjectList(Action obj1)
    {
        if (!Instance.objectList.Contains(obj1))
        {
            Instance.objectList.Add(obj1);
        }
    }

    // ���� ���
    public void UnregisterObjectList(Action obj1)
    {
        if (Instance.objectList.Contains(obj1))
        {
            Instance.objectList.Remove(obj1);
        }
    }
}
