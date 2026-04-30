using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionController : MonoBehaviour
{
    [SerializeField] private SceneTransitionModel model;

    public void CambiarEscena()
    {
        if (model.estaCargando) return;

        model.estaCargando = true;

        Debug.Log("Cambiando a la escena con índice: " + model.escenaDestino);

        SceneManager.LoadScene(model.escenaDestino);
    }
}