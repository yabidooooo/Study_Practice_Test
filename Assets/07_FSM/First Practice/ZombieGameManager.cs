using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieGameManager : MonoBehaviour
{
    private Zombie[] zombies;
    private List<BaseStateEntity> entitys;

    public static bool IsGameStop { set; get; } = false;

    private void Awake()
    {
        zombies = FindObjectsOfType<Zombie>();

        entitys = new List<BaseStateEntity>();

        for (int i = 0; i < zombies.Length; i++)
        {
            zombies[i].Setup();
            entitys.Add(zombies[i]);
        }
    }

    private void Update()
    {
        // ��� ������Ʈ�� Update()�� ȣ���� ������Ʈ ����
        for (int i = 0; i < entitys.Count; i++)
        {
            entitys[i].Updated();
        }
    }

    public static void Stop(BaseStateEntity entity)
    {
        IsGameStop = true;
    }
}
