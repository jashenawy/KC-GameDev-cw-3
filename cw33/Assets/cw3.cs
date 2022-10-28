using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class cw3 : MonoBehaviour
{
    string heroName = "Jana";
        int heroPower = 50;

    string villianName = "Mariam";
        int VillianPower = 50;

    float playerSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(VillianPower > heroPower)
        {
            print("villian is stronger");

        }
        else if(heroPower > VillianPower)
        {
            print("hero is stonger");
        }
        else
        {
            print("they are eqal");
        }

        setSpeed(2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setSpeed(float speed)
    {
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }

    
}
