using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject pausemenu;
    public bool ispaused;

    void Start()
    {
        pausemenu.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ispaused)
            {
                resumegame();
            }
            else
            {
                pauseGame();
            }
        }
    }
    public void pauseGame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }
    public void resumegame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }
    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
