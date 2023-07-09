using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] private InputActionAsset _actions;

    public InputAction _movement;
    public InputAction _shoot;

    private void Awake()
    {
        InitActions();
        _actions.Enable();
    }

    private void InitActions()
    {
        _movement = _actions["Movement"];
        _shoot = _actions["Shoot"];
    }

    public bool GetMovement() => _movement.IsPressed();

    public bool GetShoot() => _shoot.IsPressed();

    public Vector2 GetMovementDirection()
    {
        Vector2 value = _movement.ReadValue<Vector2>();
        return value;
    }
}
