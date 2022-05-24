using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Ketchup : Item
{
    public override void Active(GameObject gameObject)
    {
        if (GameController.holdingObject != null && !GameController.handsFree)
        {
            if (GameController.holdingObject.GetComponent<GetItem>().item.Name == "Hotdog")
            {
                GameController.holdingObject.GetComponent<HotdogSauces>().ketchup = true;
                GameController.holdingObject.GetComponent<HotdogSauces>().UpdateItem();
            }
        }
    }
}
