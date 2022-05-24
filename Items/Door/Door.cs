using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Door : Item
{
    public override void Active(GameObject gameObject)
    {
        if (!gameObject.GetComponent<DoorPosition>().open)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
            gameObject.GetComponent<DoorPosition>().open = true;
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            gameObject.GetComponent<DoorPosition>().open = false;
        }
    }
}
