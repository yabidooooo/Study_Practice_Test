using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    TestObject1 testObj;
    PropertyInfo propertyInfo;

    void Start()
    {
        testObj = FindObjectOfType<TestObject1>();
        propertyInfo = testObj.GetType().GetProperty("FrameCount");
        Debug.Log(propertyInfo.GetValue(testObj));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log(propertyInfo.GetValue(testObj));
        }
    }
}
