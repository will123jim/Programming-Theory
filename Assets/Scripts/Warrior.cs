using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : PlayerCharacters
{
    public int swordDamage = 20;
    public int health = 100;
        //Implementation of the abstract Attack method for warrior
        public override void Attack()
        {
            Debug.Log("Warrior swings sword!");

            //Implement attack logic specific to Warrior here
            //Using the existing attack logic in PlayerCharacters for damage application
            Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange); //Use attackRange defined in the parent class
            foreach (var enemyCollider in hitEnemies)
            {
                if (enemyCollider.CompareTag("Enemy"))//make sure your enemies are tagged as "Enemy"
                {
                    Enemy enemy = enemyCollider.GetComponent<Enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamage(attackDamage);
                        Debug.Log("Warrior attacked enemy for " + attackDamage + " damage!");
                    }
                }
            }
        }
}

