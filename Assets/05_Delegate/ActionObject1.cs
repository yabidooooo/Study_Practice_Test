using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObject1 : ActionObjectsMom
{
    public Action actionObj1;

    public int objectFrame = 10;

    void Awake()
    {
        ActionManager.Instance.RegisterObjectList(this);
    }
    void Start()
    {
        actionObj1 += PrintMessageMethod;
    }
    public void PrintMessageMethod()
    {
        Debug.Log(this.name);
    }
}
