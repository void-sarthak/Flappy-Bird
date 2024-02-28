using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool isPause = false;
    public AudioSource bgSound;
    public GameObject pauseMenu;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (isPause)
            {
                isPause = false;
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
                bgSound.Play();
            }
            else
            {
                isPause = true;
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                bgSound.Pause();
            }
        }
    }

    public void Resume()
    {
        isPause = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        bgSound.Play();
    }
}
