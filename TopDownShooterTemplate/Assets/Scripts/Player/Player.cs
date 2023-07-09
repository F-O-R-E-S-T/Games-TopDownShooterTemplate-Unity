using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInputManager _playerInputs;
    [SerializeField] private Movement _movement;
    [SerializeField] private Shoot _shoot;
    [SerializeField] private float _speedMovement = 5;

    private void Update()
    {
        Movement();
        Shoot();
    }

    private void Movement()
    {
        if (_playerInputs.GetMovement())
        {
            Debug.Log("Doing Movement");
            _movement.Move(_playerInputs.GetMovementDirection(), _speedMovement);
        }
        else
        {
            Debug.Log("Movement Stopped");
            _movement.StopMovement();
        }
    }

    private void Shoot()
    {
        if (_playerInputs.GetShoot())
        {
            _shoot.CreateBullet();
        }
    }
}
