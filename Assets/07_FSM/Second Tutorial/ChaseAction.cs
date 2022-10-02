using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Demo.FSM;

namespace Demo.MyFSM
{
    [CreateAssetMenu(menuName = "FSM/Actions/Chase")]
    public class ChaseAction : FSMAction
    {
        public override void Execute(BaseStateMachine stateMachine)
        {
            var navMeshAgent = stateMachine.GetComponent<NavMeshAgent>();
            //var enemySightSensor = stateMachine.GetComponent<EnemySightSensor>();

            //navMeshAgent.SetDestination(enemySightSensor.Player.position);
        }
    }
}

