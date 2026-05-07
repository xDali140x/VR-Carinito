using UnityEngine;

public class BriketSonido : MonoBehaviour
{
    public ParticleSystem fuegoParticles;
    public AudioSource audioSource;
    public AudioClip sonidoBriket;

    private bool estabaActivo = false;

    void Update()
    {
        // Detecta cuando el fuego se prende
        if (fuegoParticles.isPlaying && !estabaActivo)
        {
            audioSource.PlayOneShot(sonidoBriket);
            estabaActivo = true;
        }

        // Detecta cuando el fuego se apaga
        if (!fuegoParticles.isPlaying && estabaActivo)
        {
            estabaActivo = false;
        }
    }
}