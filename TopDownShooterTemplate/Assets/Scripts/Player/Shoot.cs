using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private bool _canShoot = true;

    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _bulletVelocity = 10f;
    [SerializeField] private float _bulletDelay = 1f;

    public void CreateBullet()
    {
        if (_canShoot)
        {
            StartCoroutine(WaitDelay());
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = mousePos - transform.position;
            direction.z = 0f;
            direction.Normalize();

            GameObject bala = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
            rb.velocity = direction * _bulletVelocity;
        }
        
    }

    private IEnumerator WaitDelay()
    {
        _canShoot = false;
        yield return new WaitForSeconds(_bulletDelay);
        _canShoot = true;
    }
}
