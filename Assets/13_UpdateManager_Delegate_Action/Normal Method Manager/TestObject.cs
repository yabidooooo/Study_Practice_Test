using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : ActionMom
{
    public override void OnUpdate()
    {
        Debug.Log("�߰�");

        if (Input.GetKeyDown(KeyCode.V))
        {
            ActionTest.Instance.UnregisterObject(this.gameObject);
        }
    }
}
