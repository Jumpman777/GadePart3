using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("points"))
        {
            scoreManager.IncreaseScore(10); // Increase the score by 10
        }
    }
}
