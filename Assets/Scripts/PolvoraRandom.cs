using UnityEngine;

public class PolvoraRandom : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] sonidos;

    public float tiempoMin = 4f;
    public float tiempoMax = 12f;

    void Start()
    {
        Invoke("SonarPolvora", Random.Range(tiempoMin, tiempoMax));
    }

    void SonarPolvora()
    {
        source.pitch = Random.Range(0.92f, 1.08f);

        source.PlayOneShot(
            sonidos[Random.Range(0, sonidos.Length)],
            Random.Range(0.5f, 0.12f)
        );

        Invoke("SonarPolvora", Random.Range(tiempoMin, tiempoMax));
    }
}