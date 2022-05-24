using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItem : MonoBehaviour
{
    public Transform holdPoint;
    void Update()
    {
        if (!GameController.onPause)
        {
            if (GameController.nowLookingObject != null &&
            GameController.nowLookingObject.GetComponent<GetItem>().movable &&
            GameController.handsFree &&
            Input.GetKeyDown(KeyCode.G))
            {
                GameController.holdingObject = GameController.nowLookingObject;
                GameController.holdingObject.transform.position = holdPoint.position;
                GameController.handsFree = false;
                GameController.holdingObject.GetComponent<Collider>().enabled = false;
                GameController.holdingObject.GetComponent<Rigidbody>().useGravity = false;

            }
            if (!GameController.handsFree && GameController.holdingObject != null)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0) && !GameController.handsFree && GameController.holdingObject != null)
                {
                    if (GameController.nowLookingPlace != Vector3.zero)
                    {
                        GameController.holdingObject.transform.position = GameController.nowLookingPlace + new Vector3(0, 0.1f, 0);
                        GameController.holdingObject.GetComponent<Collider>().enabled = true;
                        GameController.holdingObject.GetComponent<Rigidbody>().useGravity = true;
                        GameController.holdingObject = null;
                        GameController.handsFree = true;
                    }
                }
                else
                {
                    GameController.holdingObject.transform.position = holdPoint.position;
                    GameController.holdingObject.transform.rotation = new Quaternion(0, 0, 0, 0);
                }
            }
        }
    }
}
