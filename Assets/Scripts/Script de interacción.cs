using UnityEngine;

public class RadioController : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    public void ToggleRadio()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
        else
            audioSource.Play();
    }
}