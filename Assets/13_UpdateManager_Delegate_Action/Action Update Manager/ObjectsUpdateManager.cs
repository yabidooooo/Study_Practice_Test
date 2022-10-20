using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsUpdateManager : MonoSingleton<ObjectsUpdateManager>
{
    public List<Action> objectUpdate = new List<Action>();

    private int frameCount = 0;

    public void AddUpdate(int frame, Action action)
    {

    }
    public void AddUpdateManager(Action action)
    {
        objectUpdate.Add(action);
    }
    public void RemoveUpdateManager(Action action)
    {
        objectUpdate.Remove(action);
    }
}
