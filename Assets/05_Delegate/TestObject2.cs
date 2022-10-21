using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject2 : MonoBehaviour
{
    public int Frame;
    void Awake()
    {
        ActionManager.Instance.RegisterObjectList(OnMethod);
    }
    public void OnMethod()
    {
        Debug.Log(this.name);
    }
}
