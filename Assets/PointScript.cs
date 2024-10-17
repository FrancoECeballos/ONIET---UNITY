using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    public GameLogicScript gameLogic;
    public GameObject pointCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointCounter.GetComponent<Text>().text = "Pts: " + gameLogic.gameScore.ToString();
    }
}
