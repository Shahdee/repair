using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip buttonPressed;

    static SoundManager soundManager;
    private AudioSource audioSource;

    private void Awake() 
    {
        soundManager = this;
        audioSource = GetComponent<AudioSource>();
    }

    public static SoundManager GetSoundManager()
    {
        return soundManager;
    }

    public static void PlayButtonPressedSound()
    {
        soundManager.audioSource.PlayOneShot(soundManager.buttonPressed);
    }

    public void PlayClip()
    {

    }

}
