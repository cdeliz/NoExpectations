using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttackEvent : UnityEvent<AttackStruct, Monster>
{
    private AttackStruct attackDef;
    private Monster targetMonster;

    public AttackEvent(AttackStruct attackDef, Monster targetMonster)
    {
        this.attackDef = attackDef;
        this.targetMonster = targetMonster;
    }
}
