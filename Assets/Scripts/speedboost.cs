using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPickup : MonoBehaviour
{
    public float speedBoostMultiplier = 2f;
    public float duration = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMove playerMove = other.GetComponent<PlayerMove>();
            if (playerMove != null)
            {
                playerMove.ApplySpeedBoost(speedBoostMultiplier, duration);
                Destroy(gameObject);
            }
        }
    }
}
