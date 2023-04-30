using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    - health & shield fields
    - health & shield get/set properties
 */



public class Conditional_Statements : MonoBehaviour
{

    private int player_health = 100;
    private int player_shield = 50;


    public int Player_Health
    {
        get { return player_health; }
        set { player_health = value; }
    }

    public int Player_Shield
    {
        get { return player_shield; }
        set { player_shield = value; }
    }



    // Start
    void Start()
    {
        Debug.Log("You took " + Damage_Taken(60).ToString() + " in damage!");
    }


    // Damage_Taken (method + cond.)
    int Damage_Taken(int damage_n)
    {
        int damage_taken;

        if (damage_n < Player_Shield)
        {
            Debug.Log("Shield not destroyed");
            damage_taken = 0;
        }
        else if (damage_n == Player_Shield)
        {
            Debug.Log("Shield destroyed");
            damage_taken = 0;
        }
        else
        {
            Debug.Log("Shield destroyed & damage taken");
            damage_taken = damage_n - Player_Shield;
        }

        return damage_taken;
    }
}
