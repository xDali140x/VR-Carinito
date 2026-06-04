using UnityEngine;
using UnityEngine.AI;

public class Peaton : MonoBehaviour
{
    public NavMeshAgent AI;
    public Transform[] Objetivos;
    public Transform Objetivo;

    void Start()
    {
        Objetivo = Objetivos[Random.Range(0, Objetivos.Length)];
    }

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, Objetivo.position);

        if (distancia < 2)
        {
            Objetivo = Objetivos[Random.Range(0, Objetivos.Length)];
        }

        AI.destination = Objetivo.position;
    }
}