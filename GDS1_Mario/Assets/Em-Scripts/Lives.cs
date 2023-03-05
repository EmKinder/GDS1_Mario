using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS SCRIPT MUST REMAIN ENTACT IN ALL SCENES AFTER MENU SCREEN 

public class Lives : MonoBehaviour
{

    public int lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    public void AddLife()
    {
        lives++; 
    }

    public int getLives()
    {
        return lives; 
    }

    public void PlayerDeath()
    {
        lives -= 1; 
        if(lives == 0)
        {
            GameOver();
        }
        else
        {
            ResetAfterDeath();
        }
        
    }

    void GameOver()
    {
       //go to game over scene and then main menu 
    }

    void ResetAfterDeath()
    {
       //load lives screen with this script entact
      //reset level with this script entact 
     
    }
}
