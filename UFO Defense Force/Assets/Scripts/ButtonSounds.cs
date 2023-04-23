using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioClip buttonSound;
    private AudioSource buttonAudio;

    // Start is called before the first frame update
    void Start()
    {
        buttonAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
