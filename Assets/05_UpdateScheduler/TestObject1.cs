using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject1 : MonoBehaviour
{
    public Action<int, Action> testObjectOne;
    public int Frame = 10;
    TestUpdateScheduler tus = new TestUpdateScheduler();
    void Awake()
    {
        testObjectOne += tus.OnUpdateScheduler;
    }
    void Update()
    {
        //testObjectOne(Frame, OnMethod);
    }
    public void OnMethod()
    {
        Debug.Log(this.name);
    }
}
