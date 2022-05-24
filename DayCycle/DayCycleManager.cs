using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycleManager : MonoBehaviour
{
    void Update()
    {
        if (!GameController.onPause)
        {
            if (GameController.hour > 20 || GameController.hour < 8)
            {
                GameController.storeOpen = false;
            }
            if (GameController.day != 0 && GameController.day % 7 == 0)
            {
                GameController.mustPayBills += GameController.bills;
                GameController.mustPayRent += GameController.rent;
                if (!GameController.gangGetInfo)
                {
                    GameController.gangThrust -= 25;
                }
            }
        }
    }
}
