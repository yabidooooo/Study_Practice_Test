using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ZombieStates { Idle = 0, Chase, Attack };

public class Zombie : BaseStateEntity
{
    private ZombieState<Zombie>[] zombieStates;

    public override void Setup()
    {
        zombieStates = new ZombieState<Zombie>[3];
        zombieStates[(int)ZombieStates.Idle] = new ZombieOwnedStates.Idle();
        zombieStates[(int)ZombieStates.Chase] = new ZombieOwnedStates.Chase();
        zombieStates[(int)ZombieStates.Attack] = new ZombieOwnedStates.Attack();
    }

    public override void Updated()
    {

    }
}
