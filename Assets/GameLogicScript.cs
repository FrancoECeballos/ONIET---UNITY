using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicScript : MonoBehaviour
{
    public float gameTime = 0f;
    public float gameSpeed = 1f;
    public int gameScore = 0;
    public float staminaDepletionRate;
    private int lastSecond = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        gameSpeed += Time.deltaTime * 0.01f;
        staminaDepletionRate += Time.deltaTime * 0.01f;

        int currentSecond = Mathf.FloorToInt(gameTime);
        if (currentSecond > lastSecond)
        {
            gameScore += 100;
            lastSecond = currentSecond;
        }
    }
}