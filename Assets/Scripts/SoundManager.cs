using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance { get; private set; }//fer ho singleton

    [SerializeField] private AudioSource musicAudioSource, sfxAudioSource;//music -> música ambient des joc       sfx -> efectes de so puntuals
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            UnityEngine.Debug.Log("Tecla M");// tecla M per mutejar el renou ambient
            musicAudioSource.mute = !musicAudioSource.mute;
        }
    }

    public void playSound(AudioClip clip)// l'objecte que provoqui el renou, cridara aquesta funció amb el clip d'audio que se vulgui sentir
    {
        sfxAudioSource.PlayOneShot(clip);
    }
}
