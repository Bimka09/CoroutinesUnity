using System;
using UnityEngine;

namespace Game.Scripts.Characters
{
    [Serializable]
    public class Health
    {
        public Action OnDeath;

        [SerializeField]
        private int _maximumHealth;

        [SerializeField]
        public int currentHealth { get; private set; } = 10;

        public bool IsAlive => currentHealth > 0;

        // TODO Type of damage
        public void TakeDamage(int damage)
        {
            if (!IsAlive)
                return;

            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                Die();
            }
        }

        public void Heal()
        {
            currentHealth = _maximumHealth;
        }

        private void Die()
        {
            Debug.Log("Health.Die: ");
            OnDeath?.Invoke();
        }
    }
}