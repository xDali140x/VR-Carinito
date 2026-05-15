using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class SettingsCard : MonoBehaviour
{
    public GameObject panelSettings;
    public GameObject panelControles;
    private InputDevice rightController;

    void Start()
    {
        rightController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    void Update()
    {
        rightController.TryGetFeatureValue(
            CommonUsages.secondaryButton, out bool bPressed);

        if (bPressed)
        {
            if (panelControles.activeSelf)
            {
                panelControles.SetActive(false);
            }
            else if (panelSettings.activeSelf)
            {
                panelSettings.SetActive(false);
            }
            else
            {
                panelSettings.SetActive(true);
            }
        }
    }

    public void AbrirSettings()
    {
        panelSettings.SetActive(true);
    }

    public void AbrirControles()
    {
        panelControles.SetActive(true);
    }
    public void CerrarSettings()
    {
        panelSettings.SetActive(false);
        panelControles.SetActive(false);
    }

    public void CerrarControles()
    {
        panelControles.SetActive(false);
    }
    public void ToggleMute(bool isMuted)
    {
        AudioListener.volume = isMuted ? 0 : 1;
    }
    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SalirJuego()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}