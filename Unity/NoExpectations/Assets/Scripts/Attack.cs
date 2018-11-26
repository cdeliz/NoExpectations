using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    AttackEvent attackEvent;
    AttackStruct attackStr;
    Monster targetMonster;

    // Use this for initialization
    void Start()
    {
        attackEvent = new AttackEvent(attackStr, targetMonster);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
