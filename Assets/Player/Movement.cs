using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;

    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (Keyboard.current.aKey.isPressed)
        {
            movement.x = -1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            movement.x = 1f;
        }
        else if (Keyboard.current.wKey.isPressed)
        {
            movement.z = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            movement.z = -1f;
        }
        controller.SimpleMove(movement * speed);
    }
}
