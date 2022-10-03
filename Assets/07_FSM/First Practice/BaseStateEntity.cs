using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseStateEntity : MonoBehaviour
{
    // 파생 클래스에서 base.Setup()으로 호출
    public virtual void Setup()
    {
        Debug.Log("우어어어");
    }

    // GameManager 클래스에서 모든 에이전트의 Update()를 호출해 에이전트를 구동한다.
    public abstract void Updated();
}
