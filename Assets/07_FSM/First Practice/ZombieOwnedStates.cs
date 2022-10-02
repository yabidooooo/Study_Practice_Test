using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  ZombieOwnedStates
{
    public class Idle : ZombieState<Zombie>
    {
        public override void Enter(Zombie entity)
        {
            Debug.Log("Idle ���� ����.");
        }

        public override void Execute(Zombie entity)
        {
            Debug.Log("Idle ���� ��.");
        }

        public override void Exit(Zombie entity)
        {
            Debug.Log("Idle ���� Ż��.");
        }
    }

    public class Chase : ZombieState<Zombie>
    {
        public override void Enter(Zombie entity)
        {
            Debug.Log("Chase ���� ����.");
        }

        public override void Execute(Zombie entity)
        {
            Debug.Log("Chase ���� ��.");
        }

        public override void Exit(Zombie entity)
        {
            Debug.Log("Chase ���� Ż��.");
        }
    }

    public class Attack : ZombieState<Zombie>
    {
        public override void Enter(Zombie entity)
        {
            Debug.Log("Attack ���� Ż��.");
        }

        public override void Execute(Zombie entity)
        {
            Debug.Log("Attack ���� Ż��.");
        }

        public override void Exit(Zombie entity)
        {
            Debug.Log("Attack ���� Ż��.");
        }
    }

}
