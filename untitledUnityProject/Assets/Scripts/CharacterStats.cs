using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterStats : MonoBehaviour
{
    public string characterName;
    public int maxHealth = 100;
    public int currentHealth;

    public int damage = 10;
    public float attackRange = 2f;
    public float attackSpeed = 1.0f;

    // Constructor to initialize stats
    public CharacterStats(string name, int health, int damage, float range, float speed)
    {
        characterName = name;
        maxHealth = health;
        currentHealth = maxHealth;
        this.damage = damage;
        attackRange = range;
        attackSpeed = speed;
    }

    // Apply damage to the character
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Ensure that health doesn't go below 0
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    // Check if the character is alive
    public bool IsAlive()
    {
        return currentHealth > 0;
    }

    // Heal the character
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;

        // Ensure that health doesn't exceed the maximum
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
