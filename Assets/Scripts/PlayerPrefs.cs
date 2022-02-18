using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefs : MonoBehaviour
{
    private const string MAIN_SOUNDS_KEY = "main_sounds";
    private const string DIFFICULTY_KEY = "difficulty";
    private const string LEVEL_KEY = "level_open_";

    public static void MainSounds(float sounds)
    {
        if(sounds >= 0f && sounds <= 1f)
        {
            UnityEngine.PlayerPrefs.SetFloat(MAIN_SOUNDS_KEY, sounds);
        }
        else
        {
            Debug.LogError("Aralik Disinda Bir Deger Giremezsiniz.");
        }
    }
    public static float MainSoundsGet()
    {
        return UnityEngine.PlayerPrefs.GetFloat(MAIN_SOUNDS_KEY);
    }

    public static void LevelKey(int level)
    {
        if (level < SceneManager.sceneCountInBuildSettings)
        {
            UnityEngine.PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
        else
        {
            Debug.LogError("Oyunda Olmayan Sahne Acilamaz.");
        }
    }
    public static bool LevelIsOpen(int level)
    {
        int levelValue = UnityEngine.PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool levelIs = (levelValue == 1);
        if (level < SceneManager.sceneCountInBuildSettings)
        {
            return levelIs;
        }
        else
        {
            Debug.LogError("Oyunda Olmayan Level");
            return false;
        }
    }

    public static void Difficulty(int difficulty)
    {
        if (0 <= difficulty && 3 > difficulty)
        {
            UnityEngine.PlayerPrefs.SetInt(DIFFICULTY_KEY,difficulty);
        }
        else
        {
            Debug.LogError("Gecerli Zorluk Seviyesi Degil");
        }
    }

    public static int DifficultyGet()
    {
        return UnityEngine.PlayerPrefs.GetInt(DIFFICULTY_KEY);
    }

}
