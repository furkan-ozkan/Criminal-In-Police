using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Hotdog : Item
{
    public override void Active(GameObject gameObject)
    {
        if (GameController.hunger<=60)
        {
            GameController.hunger += 40;
            GameController.saveItems.Remove(gameObject);
            Destroy(gameObject);
        }else if (GameController.hunger > 60 && GameController.hunger <100)
        {
            GameController.hunger = 100;
            GameController.saveItems.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
