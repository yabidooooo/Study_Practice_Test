using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObject1 : ActionObjectsMom
{
    public int Frame;
    void Awake()
    {
        ActionManager.Instance.RegisterObjectList(OnUpdate);
    }
    public void OnUpdate()
    {
        Debug.Log(this.name);
    }
}
