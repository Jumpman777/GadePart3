using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class slowSpeedPickup : MonoBehaviour
{
    public float speedBoostMultiplier = 0.5f;
    public float duration = 10f;

    private void OnTriggerEnter(UnityEngine.Collider other)
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
