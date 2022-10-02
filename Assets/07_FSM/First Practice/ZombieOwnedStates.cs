using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  ZombieOwnedStates
{
    public class Idle : ZombieState<Zombie>
    {
        public override void Enter(Zombie entity)
        {
            Debug.Log("Idle 상태 입장.");
        }

        public override void Execute(Zombie entity)
        {
            Debug.Log("Idle 상태 중.");
        }

        public override void Exit(Zombie entity)
        {
            Debug.Log("Idle 상태 탈출.");
        }
    }

    public class Chase : ZombieState<Zombie>
    {
        public override void Enter(Zombie entity)
        {
            Debug.Log("Chase 상태 입장.");
        }

        public override void Execute(Zombie entity)
        {
            Debug.Log("Chase 상태 중.");
        }

        public override void Exit(Zombie entity)
        {
            Debug.Log("Chase 상태 탈출.");
        }
    }

    public class Attack : ZombieState<Zombie>
    {
        public override void Enter(Zombie entity)
        {
            Debug.Log("Attack 상태 탈출.");
        }

        public override void Execute(Zombie entity)
        {
            Debug.Log("Attack 상태 탈출.");
        }

        public override void Exit(Zombie entity)
        {
            Debug.Log("Attack 상태 탈출.");
        }
    }

}
