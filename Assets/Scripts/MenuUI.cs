using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
        // this string will store the players selected character
public static string selectedCharacter;// static variable to hold the selected charcacter
    // Start is called before the first frame update
   
    // Method to handle selecting the Warrior
public void SelectWarrior()
{
    selectedCharacter = "Warrior"; // store the selection
    SceneManager.LoadScene(1); // Load the main game scene
}
//Method to handle selecting the Wizard
public void SelectWizard()
{
    selectedCharacter = "Wizard"; // Store the selection
    SceneManager.LoadScene(1); //Load the main game scene
}

}
