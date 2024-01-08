using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region Scenario 1
    public AudioClip Scenario1;

    public AudioClip StartExtra;
    public AudioClip ExtraPanel2;

    public AudioClip S1Q1Tayla;
    public AudioClip S1A1APlayer;
    public AudioClip S1A1BPlayer;
    public AudioClip S1A1CPlayer;

    public AudioClip S1Q2Tayla;
    public AudioClip S1A2APlayer;
    public AudioClip S1A2BPlayer;
    public AudioClip S1A2CPlayer;

    public AudioClip S1Q3Tayla;
    public AudioClip S1A3APlayer;
    public AudioClip S1A3BPlayer;
    public AudioClip S1A3CPlayer;

    public AudioClip S1Q4Tayla;
    public AudioClip S1A4APlayer;
    public AudioClip S1A4BPlayer;
    public AudioClip S1A4CPlayer;

    public AudioClip S1Q5Tayla;
    public AudioClip S1A5APlayer;
    public AudioClip S1A5BPlayer;
    public AudioClip S1A5CPlayer;

    public AudioClip S1Q6Tayla;
    public AudioClip S1A6APlayer;
    public AudioClip S1A6BPlayer;
    public AudioClip S1A6CPlayer;

    public AudioClip S1Q7Tayla;
    public AudioClip S1A7APlayer;
    public AudioClip S1A7BPlayer;
    public AudioClip S1A7CPlayer;

    public AudioClip S1Q8Tayla;
    public AudioClip S1A8APlayer;
    public AudioClip S1A8BPlayer;
    public AudioClip S1A8CPlayer;

    public AudioClip S1Q9Tayla;
    public AudioClip S1A9APlayer;
    public AudioClip S1A9BPlayer;
    public AudioClip S1A9CPlayer;
    #endregion

    // Singleton instance
    private static AudioManager instance;

    // Reference to the AudioSource component
    private AudioSource audioSource;

    // Get the singleton instance
    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                // Create an empty GameObject to hold the AudioManager
                GameObject audioManagerObject = new GameObject("AudioManager");
                instance = audioManagerObject.AddComponent<AudioManager>();
            }

            return instance;
        }
    }

    private void Awake()
    {
        // Ensure only one instance exists
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        // Initialize the AudioSource component
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Play a sound with the given AudioClip
    public void PlaySound(AudioClip clip)
    {
        if(clip != null)
        audioSource.PlayOneShot(clip);
    }
    //Stop any playing sound
    public void StopSound()
    {
        audioSource.Stop();
    }
}