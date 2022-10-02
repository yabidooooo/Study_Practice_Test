using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Demo.FSM;

namespace Demo.MyFSM
{
    [CreateAssetMenu(menuName = "FSM/Decisions/In Line Of Sight")]
    public class InLineOfSightDecision : Decision
    {
        public override bool Decide(BaseStateMachine stateMachine)
        {
            //var enemyInLineOfSight = stateMachine.GetComponent<EnemySightSensor>();
            //return enemyInLineOfSight.Ping();
            return true;
        }
    }
}

