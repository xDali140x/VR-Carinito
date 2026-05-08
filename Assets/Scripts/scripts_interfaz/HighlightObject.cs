using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    public float distancia = 2f;
    public Transform jugador;
    private Outline outline;

    void Start()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, jugador.position);
        outline.enabled = dist < distancia;
    }
}