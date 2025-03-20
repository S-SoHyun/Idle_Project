using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void EnterState();
    public void UpdateState();
    public void ExitState();
}


// IDLE: ������ �ֱ�
public class IdleState : MonoBehaviour, IState
{
    Animator animator;

    public void EnterState()
    {
        animator.SetBool("Idle", true);
    }

    public void UpdateState()
    {
        transform.position = Vector3.zero;
    }

    public void ExitState()
    {
    }
}

// MOVE: �̵�. ���͸� ���� ������ ������ �ȱ�
public class MoveState : MonoBehaviour, IState
{
    Animator animator;

    public void EnterState()
    {
        animator.SetBool("Move", true);
    }

    public void UpdateState()
    {
    }

    public void ExitState()
    {
    }
}

// ATTACK: ���Ͱ� �����Ÿ� �ȿ� ���� �� ����
public class AttackState : MonoBehaviour, IState
{
    Animator animator;

    public void EnterState()
    {
        animator.SetBool("Attack", true);
    }

    public void UpdateState()
    {
    }

    public void ExitState()
    {
    }
}

// DIE: ü���� 0�� ���
public class DieState : MonoBehaviour, IState
{
    Animator animator;

    public void EnterState()
    {
        animator.SetBool("Die", true);
    }

    public void UpdateState()
    {
    }

    public void ExitState()
    {
    }
}


public class PlayerState : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
