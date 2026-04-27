using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsCard : MonoBehaviour
{
    public GameObject panelSettings;

    public void AbrirSettings()
    {
        panelSettings.SetActive(true);
    }

    // Se llama cuando el jugador hace clic fuera del panel
    void Update()
    {
        if (panelSettings.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!RectTransformUtility.RectangleContainsScreenPoint(
                    panelSettings.GetComponent<RectTransform>(),
                    Input.mousePosition,
                    Camera.main))
                {
                    panelSettings.SetActive(false);
                }
            }
        }
    }
}
