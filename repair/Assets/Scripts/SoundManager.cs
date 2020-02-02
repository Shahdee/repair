using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] private AudioClip buttonPressed;

    [SerializeField] private AudioClip[] audioClips;

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

    public void PlayButtonPressedSound()
    {
        Debug.Log("PlayButtonPressedSound");

        PlayClip(buttonPressed);
    }

    public void PlayClip(string name)
    {
        AudioClip clip = GetClip(name);
        if (clip != null){
            PlayClip(clip);
        }
    }

    AudioClip GetClip(string name){
        for (int i=0; i<audioClips.Length; i++){
            if (audioClips[i].name == name)
                return audioClips[i];
        }
        return null;
    }

    void PlayClip(AudioClip clip){

        Debug.Log("PlayClip");

        audioSource.clip = buttonPressed;
        audioSource.Play();
    }

}
