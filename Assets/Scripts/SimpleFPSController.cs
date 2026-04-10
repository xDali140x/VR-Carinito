using UnityEngine;

public class FireworksSound : MonoBehaviour
{
    public AudioClip[] fireworksClips;
    public float minTime = 2f;
    public float maxTime = 5f;
    public float radius = 20f;

    void Start()
    {
        InvokeRepeating("PlayFirework", 2f, Random.Range(minTime, maxTime));
    }

    void PlayFirework()
    {
        Vector3 randomPos = transform.position + Random.insideUnitSphere * radius;

        AudioSource.PlayClipAtPoint(
            fireworksClips[Random.Range(0, fireworksClips.Length)],
            randomPos,
            1f
        );
    }
}