using TMPro;
using UnityEngine;

public class NPCView : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;  // Panel que contiene el diálogo
    [SerializeField] private TMP_Text npcNameText;  // Referencia al texto del nombre del NPC
    [SerializeField] private TMP_Text dialogueText;  // Referencia al texto del diálogo

    // Mostrar el Panel de diálogo
    public void ShowDialogue()
    {
        dialoguePanel.SetActive(true);  // Activar el panel de diálogo
    }

    // Ocultar el Panel de diálogo
    public void HideDialogue()
    {
        dialoguePanel.SetActive(false);  // Desactivar el panel de diálogo
    }

    // Actualizar el texto del diálogo mientras el jugador interactúa
    public void UpdateDialogueText(string line)
    {
        dialogueText.text = line;  // Actualizar el texto del diálogo
    }

    // Actualizar el texto del nombre del NPC
    public void UpdateNPCName(string name)
    {
        npcNameText.text = name;  // Actualizar el nombre del NPC en el Canvas
    }

    // Lógica para desbloquear la escena o cambiar de escena
    public void UnlockScene()
    {
        // Aquí puedes poner cualquier lógica para cambiar la escena o desbloquearla.
    }
}