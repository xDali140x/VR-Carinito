using UnityEngine;

public class BaflePlaylist : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] canciones;

    private int indiceActual = 0;

    void Start()
    {
        ReproducirCancion();
    }

    void Update()
    {
        if (!source.isPlaying)
        {
            SiguienteCancion();
        }
    }

    void ReproducirCancion()
    {
        source.clip = canciones[indiceActual];
        source.Play();
    }

    void SiguienteCancion()
    {
        indiceActual++;

        if (indiceActual >= canciones.Length)
        {
            indiceActual = 0;
        }

        ReproducirCancion();
    }
}