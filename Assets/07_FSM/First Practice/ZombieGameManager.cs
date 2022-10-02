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
        // 모든 에이전트의 Update()를 호출해 에이전트 구동
        for (int i = 0; i < entitys.Count; i++)
        {
            entitys[i].Updated();
        }
    }
}
