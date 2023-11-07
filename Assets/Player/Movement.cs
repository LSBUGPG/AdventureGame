using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    Controls controls;
    InputAction movementAction;
    Vector2 movement;
    public CharacterController controller;
    public float speed = 1f;

    void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        movementAction = controls.FindAction("Movement");
        movementAction.performed += PerformMovement;
        movementAction.canceled += CancelMovement;
    }

    void OnDisable()
    {
        movementAction.performed -= PerformMovement;
        movementAction.canceled -= CancelMovement;
        controls.Dispose();
    }

    void PerformMovement(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    void CancelMovement(InputAction.CallbackContext context)
    {
        movement = Vector2.zero;
    }

    void Update()
    {
        controller.SimpleMove(new Vector3(movement.x, 0f, movement.y) * speed);
    }
}
