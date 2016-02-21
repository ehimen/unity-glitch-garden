using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public LevelManager levelManager;

    public string levelToLoadOnSave;

    public Slider volumeSlider;

    public Slider difficultySlider;

    private MusicManager musicManager;


    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefManager.GetDifficulty();
    }

    void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value);
    }


    public void SaveAndExit()
    {
        PlayerPrefManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefManager.SetDifficulty((int)difficultySlider.value);

        levelManager.LoadLevel(levelToLoadOnSave);
    }


    public void SetDefaults()
    {
        volumeSlider.value = 0.8f;
        difficultySlider.value = 1f;
    }

}
