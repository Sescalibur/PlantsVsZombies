using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionsControl : MonoBehaviour
{
    [SerializeField] Slider soundsSlider;
    [SerializeField] Slider difficultySlider;
    private MusicControl music;
    // Start is called before the first frame update
    void Start()
    {
        soundsSlider.value = PlayerPrefs.MainSoundsGet();
        difficultySlider.value = PlayerPrefs.DifficultyGet();
        music = GameObject.FindObjectOfType<MusicControl>();
        //music.GetComponent<AudioSource>().volume = soundsSlider.value;

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.MainSounds(soundsSlider.value);
        PlayerPrefs.Difficulty((int)difficultySlider.value);
        music.GetComponent<AudioSource>().volume = PlayerPrefs.MainSoundsGet();

    }

    public void Reset()
    {
        soundsSlider.value = 0.5f;
        difficultySlider.value = 1; 
    }
}
