using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : Singleton<ActionManager>
{
    List<Action> objectList = new List<Action>();
    int FrameCount = 0;
    // 스케쥴러
    public void Update()
    {
        Debug.Log("업데이트 실행");

        FrameCount += 1;
        if (FrameCount % 10 == 0)
        {
            for (int i = 0; i < Instance.objectList.Count; i++)
            {
                Instance.objectList[i].Invoke();
            }
            FrameCount = 0;
        }
    }
    // 구독 등록
    public void RegisterObjectList(Action obj1)
    {
        if (!Instance.objectList.Contains(obj1))
        {
            Instance.objectList.Add(obj1);
        }
    }
}
