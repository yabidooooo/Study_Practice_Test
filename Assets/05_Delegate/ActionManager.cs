using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoSingleton<ActionManager>
{
    ActionObject1 ao1;
    List<ActionObject1> objectList = new List<ActionObject1>();
    int FrameCount = 0;
    // �����췯�� �����ֱ� ����
    public void Update()
    {
        Debug.Log("������Ʈ ����");
        AddUpdate();
    }
    // �����췯
    public void AddUpdate()
    {
        for (int j = 0; j < objectList.Count; j++)
        {
            ao1 = objectList[j];
        }

        FrameCount++;
        if (FrameCount % ao1.objectFrame == 0)
        {
            for (int i = 0; i < objectList.Count; i++)
            {
                objectList[i].actionObj1.Invoke();
            }
            FrameCount = 0;
        }
    }
    // ���� ���
    public void RegisterObjectList(ActionObject1 obj1)
    {
        if (!Instance.objectList.Contains(obj1))
        {
            Instance.objectList.Add(obj1);
        }
    }
}
