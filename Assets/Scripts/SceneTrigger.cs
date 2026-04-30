using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    [SerializeField] private SceneTransitionController controller;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entró al trigger: " + other.name + " | Tag: " + other.tag);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detectado. Activando cambio de escena.");
            controller.CambiarEscena();
        }
    }
}