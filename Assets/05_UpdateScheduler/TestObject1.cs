using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject1 : MonoBehaviour
{
    private int frameCount;
    public int FrameCount
    {
        get
        {
            return frameCount;
        }
        set
        {
            frameCount = value;
        }
    }
    private int _number = 0;

    public Action<int, Action> actionObj;
    public int Frame = 10;
    private TestUpdateScheduler testUS = new TestUpdateScheduler();

    void Awake()
    {
        actionObj += testUS.OnUpdateScheduler;
    }
    private void Update()
    {
        actionObj(Frame, OnUpdate);

        if (Input.GetKeyDown(KeyCode.W))
        {
            _number += 1;
            FrameCount = 50 * _number;
        }
    }
    public void OnUpdate()
    {
        Debug.Log(this.name);
    }
}
