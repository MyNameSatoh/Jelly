using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Object : ZitMonoBehaviour
{
    public LibraryManager.ObjectAttributes attributes;
    public AttributeScriptableObject initialAttributes;

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
    protected override void LoadComponent()
    {
        if (initialAttributes == null) return;
        attributes.hp = initialAttributes.attributes.hp;
        attributes.curHp = attributes.hp;
        attributes.atkDamage = initialAttributes.attributes.atkDamage;
    }
    public virtual void DealAnAttack()
    {

    }
}
