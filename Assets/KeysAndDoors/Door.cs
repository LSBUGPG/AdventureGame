using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Key.Type @lock;

    public void Unlock(Key.Type key)
    {
        if (key == @lock)
        {
            Destroy(gameObject);
        }
    }
}
