using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseStateEntity : MonoBehaviour
{
    // �Ļ� Ŭ�������� base.Setup()���� ȣ��
    public virtual void Setup()
    {
        Debug.Log("�����");
    }

    // GameManager Ŭ�������� ��� ������Ʈ�� Update()�� ȣ���� ������Ʈ�� �����Ѵ�.
    public abstract void Updated();
}
