using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerTimer : MonoBehaviour
{
    [SerializeField] [Range(0, 30)] private float time;
    private float timer;
    private bool once = false;
    void Update()
    {
        if (!GameController.onPause)
        {
            if (!once)
            {
                once = true;
                timer = time;
            }
            if (GameController.activeCustomer != null && GameController.activeCustomer.GetComponent<CustomerWalk>().currentPoint == 3)
            {
                time -= Time.deltaTime;
                if (time < (timer / 3) * 2)
                {
                    GameController.activeCustomer.GetComponent<CustomerAttributes>().timeBonus = 2;
                }
                if (time < timer / 3)
                {
                    GameController.activeCustomer.GetComponent<CustomerAttributes>().timeBonus = 1;
                }
                if (time < 0)
                {
                    GameController.activeCustomer.GetComponent<CustomerAttributes>().timeBonus = 0;
                    GameController.activeCustomer.GetComponent<CustomerWalk>().currentPoint++;
                    GameController.activeCustomer = null;
                }
            }
        }
    }
}
