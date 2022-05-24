using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrder : MonoBehaviour
{
    public int orderId;
    public bool orderComplated = false;
    public void Start()
    {
        orderId = Random.Range(0,8);
        GameController.activeCustomer = gameObject;
    }
}
