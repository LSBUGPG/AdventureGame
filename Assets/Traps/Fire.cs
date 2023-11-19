using UnityEngine;

public class Fire : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.Burn();
        }
    }
}
