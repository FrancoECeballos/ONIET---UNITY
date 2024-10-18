using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    public float gameTime = 0f;
    public float gameSpeed = 1f;
    public int gameScore = 0;
    public float staminaDepletionRate;
    private int lastSecond = 0;

    private AudioSource audioSource;
    public AudioClip backgroundMusic;
    public float musicVolume = 0.5f;

    public GameObject gameOverPanel;
    private bool isGameOver = false;

    private float spaceKeyHoldTime = 0f;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.volume = musicVolume;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;

        gameTime += Time.deltaTime;
        gameSpeed += Time.deltaTime * 0.01f;
        staminaDepletionRate += Time.deltaTime * 0.01f;

        int currentSecond = Mathf.FloorToInt(gameTime);
        if (currentSecond > lastSecond)
        {
            gameScore += 100;
            lastSecond = currentSecond;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            spaceKeyHoldTime += Time.deltaTime;
            if (spaceKeyHoldTime >= 1f)
            {
                restartGame();
            }
        }
        else
        {
            spaceKeyHoldTime = 0f;
        }
    }

    public void restartGame() 
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void gameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
        audioSource.Stop();
    }
}