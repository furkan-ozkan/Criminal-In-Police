using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFoodTable : MonoBehaviour
{
    public GameObject sausage=null, bread=null, Hotdog;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<GetItem>() && collision.gameObject.GetComponent<GetItem>().item.Id == 8 && bread == null)
        {
            bread = collision.gameObject;
            collision.gameObject.GetComponent<GetItem>().movable = false;
            collision.gameObject.GetComponent<Rigidbody>().useGravity=false;
            GameController.saveItems.Remove(collision.gameObject);
        }else if (collision.gameObject.GetComponent<GetItem>() && collision.gameObject.GetComponent<GetItem>().item.Id == 9 && sausage == null)
        {
            sausage = collision.gameObject;
            collision.gameObject.GetComponent<GetItem>().movable = false;
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            GameController.saveItems.Remove(collision.gameObject);
        }else
        {

        }
    }
}
