using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class TestUpdateScheduler
{
    Dictionary<int, Action> dicList = new Dictionary<int, Action>();

    List<int> intList = new List<int>();
    List<Action> actionList = new List<Action>();

    int OneCount = 0;
    int TwoCount = 0;
    int ThreeCount = 0;

    //void Update()
    //{
    //    Debug.Log("나는 스케쥴러");

    //    foreach (KeyValuePair<int, Action> newDic in dicList)
    //    {
    //        intList.Add(newDic.Key);
    //        actionList.Add(newDic.Value);
    //    }

    //    TestOne(intList[0], actionList[0]);
    //    TestTwo(intList[1], actionList[1]);
    //    TestThree(intList[2], actionList[2]);
    //}

    public void TestOne(int frame, Action action)
    {
        OneCount += 1;
        if (OneCount % frame == 0)
        {
            action();
            OneCount = 0;
        }
    }
    //public void TestTwo(int frame, Action action)
    //{
    //    TwoCount += 1;
    //    if (TwoCount % frame == 0)
    //    {
    //        action();
    //        TwoCount = 0;
    //    }
    //}
    //public void TestThree(int frame, Action action)
    //{
    //    ThreeCount += 1;
    //    if (ThreeCount % frame == 0)
    //    {
    //        action();
    //        ThreeCount = 0;
    //    }
    //}

    //public void RegisterList(int frame, Action action)
    //{
    //    dicList.Add(frame, action);
    //}
}
