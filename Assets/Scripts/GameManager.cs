using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject warriorPrefab; //Reference to the Warrior
    public GameObject wizardPrefab; // reference to the Wizard
    public Enemy enemy; // reference to the enemy
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
 // variable to hold the instantiated player character
        GameObject playerCharacter = null; 
       
        //check which character was selecte in the MenuUI
        if (MenuUI.selectedCharacter == "Warrior")
        {
            //Instantiate the Warrior at a starting position
           playerCharacter = Instantiate(warriorPrefab, new Vector3(80, 23, 54), Quaternion.identity);
            Debug.Log("Instantiating Warrior"); // confirm instantiation
        }
        else if (MenuUI.selectedCharacter == "Wizard")
        {
            //Instnatiate the Wizard at a starting position
           playerCharacter = Instantiate(wizardPrefab, new Vector3(80, 23, 54), Quaternion.identity);
            Debug.Log("Instantiating Wizard");// confirm instantiation
        }
        else
    {
        Debug.LogWarning("No character selecter"); //warning log for no slection
    }
    if (playerCharacter != null && enemy != null)
    {
        enemy.player = playerCharacter.transform; // set the enemys player reference
        Debug.Log ("Enemy is now following: " + playerCharacter.name);
    }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
