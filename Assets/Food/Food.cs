using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public enum Type
    {
        Fruit,
        Meat,
        Bread,
        Cheese
    }

    public Type type;

    void OnTriggerEnter(Collider other)
    {
        Eat eater = other.GetComponent<Eat>();
        if (eater != null)
        {
            float energy = 0f;
            switch (type)
            {
                case Type.Fruit:
                    energy = 100f; // Apple
                    break;
                case Type.Meat:
                    energy = 300f; // Chicken Leg 
                    break;
                case Type.Bread:
                    energy = 1000f; // Loaf
                    break;
                case Type.Cheese:
                    energy = 2000f; // Wedge
                    break;
            }
            eater.Consume(energy);
            Destroy(gameObject);
        }
    }
}
