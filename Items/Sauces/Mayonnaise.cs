using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Mayonnaise : Item
{
    public override void Active(GameObject gameObject)
    {
        if (GameController.holdingObject != null && !GameController.handsFree)
        {
            if (GameController.holdingObject.GetComponent<GetItem>().item.Name == "Hotdog")
            {
                GameController.holdingObject.GetComponent<HotdogSauces>().mayonnaise = true;
                GameController.holdingObject.GetComponent<HotdogSauces>().UpdateItem();
            }
        }
    }
}
