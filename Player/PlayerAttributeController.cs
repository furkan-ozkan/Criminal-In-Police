using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributeController : MonoBehaviour
{
    private float timerForAttributes = 0;
    private float timerForAttributesWater = 0;
    void Update()
    {
        if (!GameController.onPause)
        {
            timerForAttributes += Time.deltaTime;
            timerForAttributesWater += Time.deltaTime;
            if (timerForAttributes > 9)
            {
                timerForAttributes -= 9;
                if (GameController.hunger > 0)
                {
                    GameController.hunger -= 1;
                }
                else
                {
                    GameController.health -= 5;
                    if (GameController.health < 0)
                    {
                        GameController.dead = true;
                    }
                }
            }
            if (timerForAttributesWater > 6)
            {
                timerForAttributesWater -= 6;
                if (GameController.water > 0)
                {
                    GameController.water -= 10;
                }
                else
                {
                    GameController.health -= 5;
                    if(GameController.health < 0)
                    {
                        GameController.dead = true;
                    }
                }
            }
            
        }
    }
}
