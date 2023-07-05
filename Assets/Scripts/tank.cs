using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform playerTransform;
    public float shootInterval = 2f;
    public float shootingDuration = 26f;
    public float bulletLifetime = 15f;

    private float elapsedTime = 0f;

    private void Start()
    {
        InvokeRepeating("ShootBullet", shootInterval, shootInterval);
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= shootingDuration)
        {
            CancelInvoke("ShootBullet");
        }
    }

    private void ShootBullet()
    {
        // Calculate the direction towards the player
        Vector3 direction = (playerTransform.position - transform.position).normalized;

        // Instantiate the bullet and set its position and direction
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().SetDirection(direction);

        // Destroy the bullet after its lifetime expires
        Destroy(bullet, bulletLifetime);
    }
}