using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 50;
    public Transform player;//reference to the player object
    public float moveSpeed = 3f; // speed of the enemy

void Start()
{
    //Delay the search for the player slightly to ensure the player is instantiated
    StartCoroutine(FindPlayerWithDealy());
}
IEnumerator FindPlayerWithDealy()
    {
        yield return new WaitForSeconds(0.1f); // add a small wait time
    

    //Try finding the player iwth the appropriate tag
    GameObject warrior = GameObject.FindWithTag("Warrior");
    GameObject wizard = GameObject.FindWithTag("Wizard");

if (warrior != null)
{
    player = warrior.transform;
    Debug.Log("Found Warrior as player");
}
else if (wizard != null)
{
    player = wizard.transform;
    Debug.Log("Found Wizard as player");
}
else
{
Debug.LogWarning("No warrior or Wizard found in the scene");
}
}
void Update()
{
    if (player != null)
    {
        Debug.Log("Current Player Tag " + player.tag);// log the player tag for debugging
        //Check if the player is the warrior or Wizard using tags
    
        // Calculate the direction form the enemy to the player
        Vector3 direction = player.position - transform.position;
        direction.Normalize(); //Normalize to ensure constant speed

        //move the enemy towards the player
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
    else
    {
        Debug.LogWarning("Player reference is still null");
    }
}

    public void TakeDamage( int damage)
    {
        health -= damage;
        Debug.Log("Enemy took" + damage + " damage!");

        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject);
    }
    
}
