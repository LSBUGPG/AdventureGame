using TMPro;
using UnityEngine;

public class HintUI : MonoBehaviour
{
    public TMP_Text message;

    public void Display(string message)
    {
        this.message.text = message;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
