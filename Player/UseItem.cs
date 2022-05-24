using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && GameController.nowLookingObject != null && GameController.nowLookingObject.GetComponent<GetItem>().interractable && !GameController.onPause)
        {
            GameController.nowLookingObject.GetComponent<GetItem>().item.Active(GameController.nowLookingObject);
        }
    }
}
