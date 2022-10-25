using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject2 : MonoBehaviour
{
    Action<int, Action> testObj;
    public int Frame = 20;
    TestUpdateScheduler testUS = new TestUpdateScheduler();

    void Awake()
    {
        testObj += testUS.OnUpdateScheduler;
    }
    private void Update()
    {
        testObj(Frame, OnMethod);
    }
    public void OnMethod()
    {
        Debug.Log(this.name);
    }
}
