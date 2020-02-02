using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundRandomContainer : MonoBehaviour
{

    [SerializeField] private AudioClip[] audioClips;
    

    private AudioSource source;
    public void Play()
    {
        if (!source)
        {
            source = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
            source.enabled = true;
        }
        if(audioClips!=null)
        {
            int value = Random.Range(0, audioClips.Length - 1);
            source.clip = audioClips[value];
            source.enabled = true;
            source.Play();
        }
        
    }

    public void Start()
    {
        source = GetComponent<AudioSource>();
    }
}
