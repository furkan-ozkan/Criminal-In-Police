using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillBar : MonoBehaviour
{
    private float x, y;
    [HideInInspector]
    public int id=0;
    [HideInInspector]
    public List<string> fillBarType = new List<string> { "health", "hunger", "water", "gangThrust", "policeThrust", "customerHappines", "activeGangPower", "suspicionRate" };

    private void Start()
    {
        x = gameObject.GetComponent<RectTransform>().sizeDelta.x/100;
        y = gameObject.GetComponent<RectTransform>().sizeDelta.y;
    }

    private void Update()
    {
        switch (id)
        {
            case 0:
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x*GameController.health, y);
                break;
            case 1:
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x * GameController.hunger, y);
                break;
            case 2:
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x * GameController.water, y);
                break;
            case 3:
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x * GameController.gangThrust, y);
                break;
            case 4:
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x * GameController.policeThrust, y);
                break;
            case 5:
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x*10 * GameController.customerHappines, y);
                break;
            case 6:
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x * GameController.activeGangPower, y);
                break;
            case 7:
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x * GameController.suspicionRate, y);
                break;
        }
    }

}
