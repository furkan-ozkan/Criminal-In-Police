using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FoodTable : Item
{
    public override void Active(GameObject gameObject)
    {
        if (gameObject.GetComponent<OnFoodTable>().bread != null && gameObject.GetComponent<OnFoodTable>().sausage != null)
        {
            Destroy(gameObject.GetComponent<OnFoodTable>().bread);
            Destroy(gameObject.GetComponent<OnFoodTable>().sausage);
            Instantiate(gameObject.GetComponent<OnFoodTable>().Hotdog,gameObject.transform.position+new Vector3(0,.2f,0),new Quaternion(0,0,0,0));
        }
    }
}
