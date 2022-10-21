using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : Singleton<ActionManager>
{
    List<ActionObject1> objectList = new List<ActionObject1>();
    int FrameCount = 0;
    // �����췯�� �����ֱ� ����
    public void Update()
    {
        Debug.Log("������Ʈ ����");
        Scheduler();
    }
    // �����췯
    public void Scheduler()
    {
        FrameCount += 1;
        if (FrameCount % 10 == 0)
        {
            for (int i = 0; i < objectList.Count; i++)
            {
                Debug.Log(FrameCount + " ������׽��ϴ�.");
                objectList[i].OnUpdate();
            }
            FrameCount = 0;
        }
        Debug.Log("ù��° : " + FrameCount);
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
