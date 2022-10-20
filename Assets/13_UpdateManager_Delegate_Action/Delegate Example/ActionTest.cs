using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTest : MonoSingleton<ActionTest>
{
    public List<GameObject> objList = new List<GameObject>();

    public void Update()
    {
        for (int i = 0; i < objList.Count; i++)
        {
            Debug.Log("ธÞที");
            Instance.objList[i].SendMessage("OnUpdate");
        }
    }
    public void RegisterObject(GameObject _obj)
    {
        if (!Instance.objList.Contains(_obj))
        {
            Instance.objList.Add(_obj);
        }
    }
    public void UnregisterObject(GameObject _obj)
    {
        if (Instance.objList.Contains(_obj))
        {
            Instance.objList.Remove(_obj);
        }
    }
}
