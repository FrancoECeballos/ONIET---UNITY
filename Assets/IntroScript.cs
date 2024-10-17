using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndLoadScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(7); // Wait for 7 seconds
        SceneManager.LoadScene("Gameplay"); // Load the "Gameplay" scene
    }
}