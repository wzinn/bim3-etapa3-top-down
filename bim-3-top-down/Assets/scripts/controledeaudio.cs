using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    public int volume;
    public int volumeSFX;
    public bool musica;
    
    public Slider volumeslider;
    public Slider volumeSFXSlider;
    public Toggle toggleMusica;
    public TMP_Text textoMusica;


    void Start()
    {
        musica = toggleMusica.isOn;
        volume = (int) volumeSFXSlider.value;
        volumeSFX = (int) volumeSFXSlider.value;
    }

    void Update()
    {
        musica = toggleMusica.isOn;
        volume = (int) volumeSFXSlider.value;
        volumeSFX = (int) volumeSFXSlider.value;

        if (musica == true)
        {
            textoMusica.text = "ligado";
            textoMusica.color = Color.green;
        }

        else
        {
            textoMusica.text = "desligado";
            textoMusica.color = Color.red;
        }
    }
}










