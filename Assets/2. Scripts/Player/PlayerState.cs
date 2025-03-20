using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void EnterState();
    public void UpdateState();
    public void ExitState();
}


// IDLE: 가만히 있기
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

// MOVE: 이동. 몬스터를 만날 때까지 앞으로 걷기
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

// ATTACK: 몬스터가 사정거리 안에 있을 때 공격
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

// DIE: 체력이 0일 경우
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
