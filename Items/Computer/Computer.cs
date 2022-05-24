using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Computer : Item
{
    public override void Active(GameObject gameObject)
    {
        GameObject.FindGameObjectWithTag("UiController").GetComponent<UiController>().Computer.SetActive(!GameObject.FindGameObjectWithTag("UiController").GetComponent<UiController>().Computer.activeInHierarchy);

        
    }
}
