using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Bed : Item
{
    public override void Active(GameObject gameObject)
    {
        SaveSystem.SaveGame();
    }
}
