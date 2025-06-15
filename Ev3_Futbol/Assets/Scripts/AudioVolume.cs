using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    public Toggle muteToggle;
    // Start is called before the first frame update
    void Start()
    {
        // Configura valores iniciales
        audioSource.volume = volumeSlider.value;
        audioSource.mute = muteToggle.isOn;

        // Escuchar cambios en el slider y el toggle
        volumeSlider.onValueChanged.AddListener(CambiarVolumen);
        muteToggle.onValueChanged.AddListener(CambiarMute);
    }
    public void CambiarVolumen(float nuevoVolumen)
    {
        audioSource.volume = nuevoVolumen;
        Debug.Log("Volumen actual: " + nuevoVolumen);
    }
    public void CambiarMute(bool enSilencio)
    {
        audioSource.mute = enSilencio;
        Debug.Log("Audio " + (enSilencio ? "Silenciado" : "Activo"));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
