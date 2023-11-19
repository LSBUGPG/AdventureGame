using UnityEngine;

public class Hint : MonoBehaviour
{
    public HintUI hint;
    public string message;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hint.Display(message);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hint.Hide();
        }
    }
}
