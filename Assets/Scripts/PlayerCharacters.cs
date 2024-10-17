using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerCharacters : MonoBehaviour// made an abstract class
{
  
    public float speed = 5f;
//Abstract method for attack
    public abstract void Attack();
    public float attackRange = 2f;// Range of the attack
    public int attackDamage = 10; // Amount of damage the player can inflict
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void Move(Vector3 direction)
    {
        //move the character based on direction
    transform.position += direction * speed * Time.deltaTime; 
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        //check for key inputs and set direction
        {
        if (Input.GetKey(KeyCode.RightArrow))
        direction = Vector3.forward;
        if (Input.GetKey(KeyCode.LeftArrow))
        direction = Vector3.back;
        if (Input.GetKey(KeyCode.UpArrow))
        direction = Vector3.left;
        if (Input.GetKey(KeyCode.DownArrow))
        direction = Vector3.right;

//Call the Move function to move the character
Move(direction);
// Trigger attack if Space key is pressed
if (Input.GetKeyDown(KeyCode.Space))
{
    Attack(); //call the abstract attack method, specific to the subclass

    // Implement the attack logic
    Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange); //use attack range defined in class
    foreach (var enemyCollider in hitEnemies)
    {
        if (enemyCollider.CompareTag("Enemy"))// make sure your enemies are tagged as "Enemy"
        {
            Enemy enemy = enemyCollider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(attackDamage);
                Debug.Log("Attacked enemy for" + attackDamage + " damage!");
            }
        }
    }
}
    }
    
}
       
 }
