using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public GameLogicScript gameLogic;
    public GameObject timerObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int currentSecond = Mathf.FloorToInt(gameLogic.gameTime);
        timerObject.GetComponent<Text>().text = currentSecond.ToString() + " s";
    }
}
