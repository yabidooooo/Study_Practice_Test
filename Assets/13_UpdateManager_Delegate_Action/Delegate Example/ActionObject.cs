using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObject : ActionMom
{
    public override void OnUpdate()
    {
        Debug.Log("�ȳ�");

        if (Input.GetKeyDown(KeyCode.F))
        {
            ActionTest.Instance.UnregisterObject(this.gameObject);
        }
    }
}
