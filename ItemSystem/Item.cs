using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [SerializeField] private int id;
    [SerializeField] private string name;
    [SerializeField] private string description;
    [SerializeField] private int price;

    public int Id { get => id;}
    public string Name { get => name;}
    public string Description { get => description;}
    public int Price { get => price;}

    public virtual void Active(GameObject gameObject)
    {

    }
}
