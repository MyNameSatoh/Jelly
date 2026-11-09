using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AttackingLibrary : MonoBehaviour
{
    public void SingleTargetAttack(Object attacker, Object target)
    {
        if (target == null) return;
        target.ReceiveDamage(attacker);
    }
    public void AoETargetAttack(Object attacker, List<Object> targets)
    {
        foreach (Object target in targets)
        {
            if (target == null) continue;

            target.ReceiveDamage(attacker);
        }
    }
}
