using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ZombieStates { Idle = 0, Chase, Attack };

public class Zombie : BaseStateEntity
{
    public GameObject player;
    public float distance;

    private ZombieState<Zombie>[] zombieStates;
    private ZombieStateMachine<Zombie> zombieStateMachine;

    public override void Setup()
    {
        base.Setup();

        zombieStates = new ZombieState<Zombie>[3];
        zombieStates[(int)ZombieStates.Idle] = new ZombieOwnedStates.Idle();
        zombieStates[(int)ZombieStates.Chase] = new ZombieOwnedStates.Chase();
        zombieStates[(int)ZombieStates.Attack] = new ZombieOwnedStates.Attack();

        // 상태를 관리하는 StateMachine에 메모리를 할당하고, 첫 상태를 설정
        zombieStateMachine = new ZombieStateMachine<Zombie>();
        zombieStateMachine.Setup(this, zombieStates[(int)ZombieStates.Idle]);
    }

    public override void Updated()
    {
        player = GameObject.Find("Player");
        Debug.Log("플레이어 발견");

        distance = Vector3.Distance(player.transform.position, this.transform.position);

        zombieStateMachine.Execute();
    }

    public void ChangeState(ZombieStates newState)
    {
        zombieStateMachine.ChangeState(zombieStates[(int)newState]);
    }
}
