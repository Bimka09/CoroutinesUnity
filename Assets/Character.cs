using System;
using System.Collections;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    public int Health;
    public Animator _animator;

    public IEnumerator Attack(Character attackedCharacter)
    {
        _animator.SetTrigger("IsShooting");
        yield return null;

        var animatorStateInfo = _animator.GetCurrentAnimatorStateInfo(0);
        yield return new WaitForSeconds(2);
        attackedCharacter.Health -= 1;

        if(attackedCharacter.Health <= 0)
        {
            attackedCharacter.Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{GetType().Name} I'm dead");
        _animator.SetBool("IsDead", true);
    }
}
