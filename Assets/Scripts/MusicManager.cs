using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] clipsForLevels;

    private AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnLevelWasLoaded(int level)
    {
        if (audioSource && clipsForLevels[level])
        {
            // Only play new music if we're not already playing it.
            if (audioSource.clip != clipsForLevels[level])
            {
                audioSource.Stop();
                audioSource.clip = clipsForLevels[level];
                audioSource.Play();
            }
        }
    }

}
