using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseUI;
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseUI.SetActive(true);
                audioSource.Stop();
            }
           else
            {
                Time.timeScale = 1;
                pauseUI.SetActive(false);
                audioSource.Play();
            }
        }
        
    }
}
