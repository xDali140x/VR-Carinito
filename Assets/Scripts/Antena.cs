using UnityEngine;

public class Antena : MonoBehaviour
{
    [Header("Objeto B que va a desaparecer")]
    public GameObject objetoB;

    [Header("Objeto C que va a aparecer")]
    public GameObject objetoC;

    private void Start()
    {
        // Al iniciar, el objeto C empieza apagado
        objetoC.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto que entró al collider es el objeto B
        if (other.gameObject == objetoB)
        {
            objetoB.SetActive(false);
            objetoC.SetActive(true);
        }
    }
}