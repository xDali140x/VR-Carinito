using TMPro;
using UnityEngine;

public class NPCView : MonoBehaviour
{
    [Header("UI de interacción")]
    [SerializeField] private GameObject interactPrompt;

    [Header("UI de diálogo")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text npcNameText;
    [SerializeField] private TMP_Text dialogueText;

    public void ShowInteractPrompt()
    {
        if (interactPrompt != null)
            interactPrompt.SetActive(true);
    }

    public void HideInteractPrompt()
    {
        if (interactPrompt != null)
            interactPrompt.SetActive(false);
    }

    public void ShowDialogue(string npcName, string line)
    {
        if (dialoguePanel != null)
            dialoguePanel.SetActive(true);

        if (npcNameText != null)
            npcNameText.text = npcName;

        if (dialogueText != null)
            dialogueText.text = line;
    }

    public void HideDialogue()
    {
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
    }

    public void UpdateDialogueText(string line)
    {
        if (dialogueText != null)
            dialogueText.text = line;
    }
}