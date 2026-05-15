using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    [SerializeField] private NPCController npcController;

    // Cuando el jugador entra en el área del trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("El jugador ha entrado en el rango del NPC.");
            npcController.PlayerEnteredRange();  // Iniciar el diálogo y activar el Canvas
        }
    }

    // Cuando el jugador sale del área del trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("El jugador ha salido del rango del NPC.");
        
        }
    }
}