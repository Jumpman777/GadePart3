using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    public RawImage collectedImage;
    public Texture collectedTexture; // Assign the appropriate texture for this collectible in the Inspector

    public AudioSource collectSound; // Assign the collect sound effect in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collectedImage.texture = collectedTexture; // Assign the collected texture
            collectedImage.enabled = true; // Show the collected image
            StartCoroutine(HideCollectedImage());
            collectSound.Play(); // Play the collect sound effect
            this.gameObject.SetActive(false);
        }
    }

    private IEnumerator HideCollectedImage()
    {
        yield return new WaitForSeconds(10f); // Display the collected image for 10 seconds

        collectedImage.enabled = false; // Hide the collected image
    }
}