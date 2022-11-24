using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsVolumen : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void CambiarVolumen ( float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
}
