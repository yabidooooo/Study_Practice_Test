using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    TestObject1 testObj;
    MethodInfo methodInfo;
    PropertyInfo propertyInfo;

    void Start()
    {
        testObj = FindObjectOfType<TestObject1>();
        methodInfo = testObj.GetType().GetMethod("OnMethod");
        //propertyInfo = testObj.GetType().GetProperty("FrameCount");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            methodInfo.Invoke(testObj, null);
            //Debug.Log(propertyInfo.GetValue(testObj));
        }
    }
}
