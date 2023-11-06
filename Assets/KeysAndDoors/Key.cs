using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public enum Type
    {
        Lock1,
        Lock2,
        Lock3
    }

    public Type type;

    void OnTriggerEnter(Collider other)
    {
        Inventory inventory = other.GetComponent<Inventory>();
        if (inventory != null)
        {
            inventory.AddKey(type);
            Destroy(gameObject);
        }
    }
}
