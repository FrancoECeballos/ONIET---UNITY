using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildindex + 1);
    }
    public void Arcade()
    {
        int aux = 0;
    }
    public void Tutorial()
    {
       int aux= 0;
    }
    public void Salir()
    {
        Debug.log("Saliendo...")
        Application.Quit();
    }
}
