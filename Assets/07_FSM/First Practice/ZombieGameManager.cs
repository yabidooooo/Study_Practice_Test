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
        // 모든 에이전트의 Update()를 호출해 에이전트 구동
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
