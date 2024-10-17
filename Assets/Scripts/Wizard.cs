using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : PlayerCharacters
{
            public int spellDamage = 20;
            public int health = 100;
            //Implementation fo the absract Attack method for Mage
            public override void Attack()
            {
                //logic for casting a spell 
                Debug.Log("Mage casts a fireball");

                //implement attack logic specific to Wizard here
                //using hte existing attack logic in playercharacters

                Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange); // use attackrange defined in the parent class
                foreach (var enemyCollider in hitEnemies) // make sure your enemies are tagged as enemy
                {
                    if (enemyCollider.CompareTag("Enemy"))
                    {
                        Enemy enemy = enemyCollider.GetComponent<Enemy>();
                        if (enemy != null)
                        {
                            enemy.TakeDamage(attackDamage);
                            Debug.Log("Wizard attacked enemy for " + attackDamage + "damage!");
                        }
                    }
                }
            }
 }
    
