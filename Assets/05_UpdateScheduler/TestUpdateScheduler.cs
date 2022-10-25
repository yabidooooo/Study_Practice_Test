using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUpdateScheduler : Singleton<TestUpdateScheduler>
{
    List<Action> objectList = new List<Action>();
    int FrameCount = 0;

    // 스케쥴러 돌려주기
    public void Update()
    {
        Debug.Log("업데이트 실행");
    }

    // 스케쥴러
    public void OnUpdateScheduler(int frame, Action action)
    {
        FrameCount += 1;
        if (FrameCount % frame == 0)
        {
            action();
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

    // 구독 취소
    public void UnregisterObjectList(Action obj1)
    {
        if (Instance.objectList.Contains(obj1))
        {
            Instance.objectList.Remove(obj1);
        }
    }
}
