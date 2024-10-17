using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaScript : MonoBehaviour
{
    public GameObject staminaBar;
    public float stamina;

    public GameLogicScript gameLogic;
    void Start()
    {
        stamina = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameLogic != null)
        {
            stamina -= gameLogic.staminaDepletionRate;
            staminaBar.transform.localScale = new Vector3(stamina / 100, 1, 1);
        }
    }
}
