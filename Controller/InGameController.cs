using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameController : MonoBehaviour
{
    void Update()
    {
        if (GameController.dead)
        {
            GameController.onPause = true;
        }
    }
}
