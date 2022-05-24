using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchtoPlayer : MonoBehaviour
{
    FieldOfView fov;
    float timer = 3;
    bool once = false;
    void Start()
    {
        fov = gameObject.GetComponent<FieldOfView>();
    }
    void Update()
    {
        if (fov.canSeePlayer && !GameController.onPause)
        {
            if (GameController.thrashChecking)
            {
                if (!once)
                {
                    timer -= Time.deltaTime;
                    if (timer < 0)
                    {
                        once = true;
                        GameController.customerHappines -= .5f;
                    }
                }
            }
        }
    }
}
