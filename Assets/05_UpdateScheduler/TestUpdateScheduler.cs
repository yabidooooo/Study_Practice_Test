using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class TestUpdateScheduler : MonoSingleton<TestUpdateScheduler>
{
    int FrameCount = 0;

    public void OnUpdateScheduler(int frame, Action action)
    {
        FrameCount += 1;
        if (FrameCount % frame == 0)
        {
            action();
            FrameCount = 0;
        }
    }
}
