using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObject1 : ActionObjectsMom
{
    public Action actionObj1;

    void Awake()
    {
        ActionManager.Instance.RegisterObjectList(this);
    }
    public void OnUpdate()
    {
        Debug.Log(this.name);
    }
}
