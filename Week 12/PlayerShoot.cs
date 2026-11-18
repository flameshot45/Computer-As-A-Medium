using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Updates Once Per Frame.
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        // Pressing space shoots out Magical Bullets.
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
