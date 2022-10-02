using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieGameManager : MonoBehaviour
{
    private List<BaseStateEntity> entitys;

    private void Awake()
    {
        entitys = new List<BaseStateEntity>();
    }

    private void Update()
    {
        // ��� ������Ʈ�� Update()�� ȣ���� ������Ʈ ����
        for (int i = 0; i < entitys.Count; i++)
        {
            entitys[i].Updated();
        }
    }
}
