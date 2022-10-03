using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieStateMachine<T> where T : class
{
    private T ownerEntity;              // StateMachine�� ������
    private ZombieState<T> currentState;      // ���� ����
    private ZombieState<T> previousState;      // ���� ����
    private ZombieState<T> globalState;      // ���� ����

    public void Setup(T owner, ZombieState<T> entryState)
    {
        ownerEntity = owner;
        currentState = null;
        previousState = null;
        globalState = null;

        // entryState ���·� ���� ����
        ChangeState(entryState);
    }

    public void Execute()
    {
        if (currentState != null)
        {
            currentState.Execute(ownerEntity);
        }
    }

    public void ChangeState(ZombieState<T> newState)
    {
        // ���� �ٲٷ��� ���°� ��������� ���¸� �ٲ��� �ʴ´�
        if (newState == null)
        {
            return;
        }

        // ���� ������� ���°� ������ Exit() �޼ҵ� ȣ��
        if (currentState != null)
        {
            // ���°� ����Ǹ� ���� ���´� ���� ���°� �Ǳ� ������ previousState�� ����
            previousState = currentState;

            currentState.Exit(ownerEntity);
        }

        // ���ο� ���·� �����ϰ�, ���� �ٲ� ������ Enter() �޼ҵ� ȣ��
        currentState = newState;
        currentState.Enter(ownerEntity);
    }
}
