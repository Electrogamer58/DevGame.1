using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : ScriptableObject
{
    public GameObject prefab;
    public float price;
    public float maxHealth;
    public float maxEnergy;
    public float critChance;
    public float power;
    public string _name;
}
