using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Properties
*/


public class Properties : MonoBehaviour
{

    private int player_health = 100;

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

    public string Display_Player_Health_Percentage
    {
        get
        {
            string health = player_health.ToString() + "%";
            return health;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        Player_Health -= 25;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Display_Player_Health_Percentage);
    }
}
