using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.onPause)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (GameController.nowLookingObject != null)
            {
                GameController.lastLookingObject = GameController.nowLookingObject;
                GameController.nowLookingPlace = Vector3.zero;
                GameController.nowLookingObject = null;
            }
            if (Physics.Raycast(ray, out hit, 5))
            {
                GameController.nowLookingPlace = hit.point;
                var selection = hit.transform;
                if (selection.GetComponent<GetItem>() != null)
                {
                    GameController.nowLookingObject = selection.gameObject;
                }
            }
        }

    }
}
