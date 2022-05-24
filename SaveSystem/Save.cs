using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public bool save = false;
    void Start()
    {
        if (save)
        {
            GameController.saveItems.Add(gameObject);
        }
    }
}
