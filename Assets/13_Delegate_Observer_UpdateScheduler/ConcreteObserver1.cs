using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteObserver1 : Observer
{
    public override void Update()
    {
        Debug.Log("���� 1");
    }
}
