using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrderController : MonoBehaviour
{
    private void Update()
    {
        if (GameController.activeCustomer != null && GameController.activeCustomer.GetComponent<CustomerWalk>().currentPoint == 3)
        {
            // order ui hazýrla ve onu düzenle
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<GetItem>() && GameController.activeCustomer != null && other.gameObject.GetComponent<GetItem>().item.Id == GameController.activeCustomer.GetComponent<CustomerOrder>().orderId &&
               GameController.activeCustomer.GetComponent<CustomerWalk>().currentPoint == 3 && GameController.activeCustomer.GetComponent<CustomerAttributes>().timeBonus>0)
        {
            switch (GameController.activeCustomer.GetComponent<CustomerAttributes>().timeBonus)
            {
                case 3:
                    if(GameController.customerHappines<GameController.customerHappinesMax)
                        GameController.customerHappines += 0.1f;
                    if (GameController.customerHappines > GameController.customerHappinesMax)
                        GameController.customerHappines = GameController.customerHappinesMax;
                    break;
                case 1:
                    GameController.customerHappines -= 0.2f;
                    break;
            }
            GameController.money += ((other.gameObject.GetComponent<GetItem>().item.Price) * GameController.customerHappines);
            GameController.activeCustomer.GetComponent<CustomerOrder>().orderComplated = true;
            GameController.activeCustomer.GetComponent<CustomerWalk>().currentPoint++;
            GameController.activeCustomer = null;
            Destroy(other.gameObject);
            Debug.Log("Money : " + GameController.money);
            Debug.Log("Customer Happines : " + GameController.customerHappines);
        }
        else if (other.gameObject.GetComponent<GetItem>() && GameController.activeCustomer != null && other.gameObject.GetComponent<GetItem>().item.Id != GameController.activeCustomer.GetComponent<CustomerOrder>().orderId)
        {
            // yanlýþ ürün
            GameController.customerHappines -= .2f;
            Debug.Log("Customer Happines : " + GameController.customerHappines);
        }
    }
}
