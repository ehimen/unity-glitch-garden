using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        } else
        {
            Debug.LogError("Master volume out of bounds: " + volume);
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY, 1f);
    }


    public static void UnlockLevel(int level)
    {
        if (ValidateLevel(level))
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
    }

    public static bool IsLevelUnlocked(int level)
    {
        if (ValidateLevel(level))
        {
            return (1 == PlayerPrefs.GetInt(LEVEL_KEY + level.ToString()));
        }

        return false;
    }

    public static int SetDifficulty(int difficulty)
    {
        difficulty = (int)Mathf.Clamp(difficulty, 1f, 3f);
        PlayerPrefs.SetInt(DIFFICULTY_KEY, difficulty);

        return difficulty;
    }

    public static int GetDifficulty()
    {
        return PlayerPrefs.GetInt(DIFFICULTY_KEY, 1);
    }


    private static bool ValidateLevel(int level)
    {
        if (level <= SceneManager.sceneCount - 1 && level >= 0) {
            return true;
        }

        Debug.LogError("Level out of bounds: " + level);

        return false;
    }

}
