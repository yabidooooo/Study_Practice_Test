using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseStateEntity : MonoBehaviour
{
    public virtual void Setup()
    {

    }

    public abstract void Updated();
}
