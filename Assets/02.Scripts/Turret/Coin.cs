using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Coin : MonoBehaviour, IItem
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
        Debug.Log("코인 획득");
    }
}
