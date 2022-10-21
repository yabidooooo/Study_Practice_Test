using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : Singleton<ActionManager>
{
    List<ActionObject1> objectList = new List<ActionObject1>();
    int FrameCount = 0;
    // 스케쥴러를 돌려주기 위함
    public void Update()
    {
        Debug.Log("업데이트 실행");
        Scheduler();
    }
    // 스케쥴러
    public void Scheduler()
    {
        FrameCount += 1;
        if (FrameCount % 10 == 0)
        {
            for (int i = 0; i < objectList.Count; i++)
            {
                Debug.Log(FrameCount + " 실행시켰습니다.");
                objectList[i].OnUpdate();
            }
            FrameCount = 0;
        }
        Debug.Log("첫번째 : " + FrameCount);
    }
    // 구독 등록
    public void RegisterObjectList(ActionObject1 obj1)
    {
        if (!Instance.objectList.Contains(obj1))
        {
            Instance.objectList.Add(obj1);
        }
    }
}
