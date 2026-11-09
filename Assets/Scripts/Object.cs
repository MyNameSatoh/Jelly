using JetBrains.Annotations;
using UnityEngine;

public class Object : MonoBehaviour
{
    public LibraryManager.ObjectAttributes attributes;

    public void ReceiveDamage(Object attacker)
    {
        if (attacker == null) return;
        attributes.curHp -= attacker.attributes.atkDamage;
        if (attributes.curHp <= 0) Dead();
    }
    public void Dead()
    {
        Destroy(gameObject);
    }
    public virtual void Attack(Object target)
    {
        if (target == null) return;
        target.ReceiveDamage(this);
    }
}
