using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    [SerializeField] private NPCController npcController;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo entró al trigger: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("✔ PLAYER detectado entrando al trigger");
            npcController.PlayerEnteredRange();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Algo salió del trigger: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("❌ PLAYER salió del trigger");
            npcController.PlayerExitedRange();
        }
    }
}