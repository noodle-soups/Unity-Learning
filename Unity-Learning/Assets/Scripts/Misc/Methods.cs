using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Classes
    - fields        --> class-level variable
    - properties    --> flexible mechanism to read, write, or compute thevalue of a field
    - methods       --> block of code that runs when called, with ability to pass parameters
 
 */


/* Methods
    - can return or not return a value
    - void  --> not returning value
 */


public class Methods : MonoBehaviour
{


    private int player_health = 100;


    /* Player_Health (property)
        - get/set player_health
     */
    public int Player_Health
    {
        get
        {
            return player_health;
        }

        set
        {
            player_health = value;
        }
    }


    // Start
    void Start()
    {
        Take_Damage_n(45);
        Debug.Log(Player_Health);
    }


    // Inflicts damage (method)
    private void Take_Damage_10()
    {
        Player_Health -= 10;
    }


    // Will return Player_Health (method)
    int Take_Damage_10_Show()
    {
        Player_Health -= 10;
        return Player_Health;
    }


    // Damage parameter "n" (method)
    void Take_Damage_n(int n_damage)
    {
        Player_Health -= n_damage;
    }


    // Update
    void Update()
    {
        
    }
}
