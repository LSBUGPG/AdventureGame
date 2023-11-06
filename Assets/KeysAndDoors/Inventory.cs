using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Key.Type> keys = new List<Key.Type>();

    public void AddKey(Key.Type key)
    {
        keys.Add(key);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Door door = hit.gameObject.GetComponent<Door>();
        if (door != null)
        {
            foreach (Key.Type key in keys)
            {
                door.Unlock(key);
            }
        }
    }
}
