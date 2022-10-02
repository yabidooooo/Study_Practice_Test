using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Demo.FSM;
using UnityEngine.AI;

namespace Demo.MyFSM
{
    [CreateAssetMenu(menuName = "FSM/Actions/Patrol")]
    public class PatrolAction : FSMAction
    {
        public override void Execute(BaseStateMachine stateMachine)
        {
            var navMeshAgent = stateMachine.GetComponent<NavMeshAgent>();
            //var patrolPoints = stateMachine.GetComponent<PatrolAction>();

            //if (patrolPoints.HasReached(navMeshAgent))
            //{
            //    navMeshAgent.SetDestination(patrolPoints.GetNext().position);
            //}
        }
    }
}

