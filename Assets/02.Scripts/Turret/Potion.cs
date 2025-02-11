using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Potion : MonoBehaviour, IItem
{
    private ItemManager itemManager;
    
    void Start()
    {
        itemManager = FindObjectOfType<ItemManager>();
    }

    void OnMouseDown()
    {
        itemManager.GetItem(this.gameObject);
        this.GameObject().SetActive(false);
    }
    public void Use()
    {
        Debug.Log("체력 획득");
    }
}
