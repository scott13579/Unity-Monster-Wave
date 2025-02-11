using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MagicStone : MonoBehaviour, IItem
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
        Debug.Log("마나 획득");
    }
}
