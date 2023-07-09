using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 _direction;

    [SerializeField] private Rigidbody2D _objectToMove;

    public Vector2 Direction { get => _direction; set => _direction = value; }

    public void Move(Vector2 direction, float force)
    {
        _objectToMove.velocity = direction.normalized * force;
    }

    public void StopMovement()
    {
        _objectToMove.velocity = Vector2.zero;
    }
}
