using UnityEngine;

public class VelaSonido : MonoBehaviour
{
    public ParticleSystem fuegoParticles;
    public AudioSource audioSource;

    private bool sonidoIniciado = false;

    void Update()
    {
        // Si las partículas están activas y el sonido no ha iniciado
        if (fuegoParticles.isPlaying && !sonidoIniciado)
        {
            audioSource.Play();
            sonidoIniciado = true;
        }

        // Si las partículas se apagan
        if (!fuegoParticles.isPlaying && sonidoIniciado)
        {
            audioSource.Stop();
            sonidoIniciado = false;
        }
    }
}