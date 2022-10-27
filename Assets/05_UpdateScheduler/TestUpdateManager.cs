using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class TestUpdateManager : MonoBehaviour
{
    int OneCount = 0;
    int TwoCount = 0;
    int ThreeCount = 0;

    TestObject1 testOne;
    TestObject2 testTwo;
    TestObject3 testThree;

    TestUpdateScheduler tus = new TestUpdateScheduler();

    private void Start()
    {
        testOne = FindObjectOfType<TestObject1>();
        testTwo = FindObjectOfType<TestObject2>();
        testThree = FindObjectOfType<TestObject3>();
    }

    void Update()
    {
        tus.TestOne(testOne.Frame, testOne.OnMethodOne);

        Debug.Log("나는 스케쥴러");

        //TestOne(testOne.Frame, testOne.OnMethodOne);
        //TestTwo(testTwo.Frame, testTwo.OnMethodTwo);
        //TestThree(testThree.Frame, testThree.OnMethodThree);
    }

    //public void TestOne(int frame, Action action)
    //{
    //    OneCount += 1;
    //    if (OneCount % frame == 0)
    //    {
    //        action();
    //        OneCount = 0;
    //    }
    //}
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
}
