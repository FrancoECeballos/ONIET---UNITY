using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenScript : MonoBehaviour
{
    public GameObject image;
    public float amplitude = 10f;
    public float frequency = 1f;
    private Vector3 initialPosition;

    private AudioSource audioSource;
    public AudioClip backgroundMusic;
    public float musicVolume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (image != null)
        {
            initialPosition = image.transform.position;
        }

        // Initialize the AudioSource component
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
        if (image != null)
        {
            float newY = initialPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;
            image.transform.position = new Vector3(initialPosition.x, newY, initialPosition.z);
        }
    }
}