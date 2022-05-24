using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogSauces : MonoBehaviour
{
    public bool ketchup=false, mayonnaise=false, mustard=false;
    [SerializeField] private GameObject ket, may, mus;
    private OrderList or;
    private void Start()
    {
        or = GameObject.FindGameObjectWithTag("GameController").GetComponent<OrderList>();
    }
    public void UpdateItem()
    {
        if (ketchup)
        {
            gameObject.GetComponent<GetItem>().item = or._orderList[1];
            ket.SetActive(true);
            may.SetActive(false);
            mus.SetActive(false);
        }
        if (mayonnaise)
        {
            gameObject.GetComponent<GetItem>().item = or._orderList[2];
            ket.SetActive(false);
            may.SetActive(true);
            mus.SetActive(false);
        }
        if (mustard)
        {
            gameObject.GetComponent<GetItem>().item = or._orderList[3];
            ket.SetActive(false);
            may.SetActive(false);
            mus.SetActive(true);
        }

        if (ketchup && mayonnaise)
        {
            gameObject.GetComponent<GetItem>().item = or._orderList[4];
            ket.SetActive(true);
            may.SetActive(true);
            mus.SetActive(false);
        }
        if (ketchup && mustard)
        {
            gameObject.GetComponent<GetItem>().item = or._orderList[5];
            ket.SetActive(true);
            may.SetActive(false);
            mus.SetActive(true);
        }
        if (mayonnaise && mustard)
        {
            gameObject.GetComponent<GetItem>().item = or._orderList[6];
            ket.SetActive(false);
            may.SetActive(true);
            mus.SetActive(true);
        }

        if (ketchup && mayonnaise && mustard)
        {
            gameObject.GetComponent<GetItem>().item = or._orderList[7];
            ket.SetActive(true);
            may.SetActive(true);
            mus.SetActive(true);
        }
    }
}
