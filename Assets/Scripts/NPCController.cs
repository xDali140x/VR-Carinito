using UnityEngine;

[RequireComponent(typeof(NPCModel))]
[RequireComponent(typeof(NPCView))]
public class NPCController : MonoBehaviour
{
    private NPCModel model;
    private NPCView view;

    private int currentLineIndex = 0;

    private void Awake()
    {
        model = GetComponent<NPCModel>();
        view = GetComponent<NPCView>();
    }

    public void PlayerEnteredRange()
    {
        Debug.Log("PlayerEnteredRange() llamado");

        model.SetPlayerInRange(true);

        if (!model.IsTalking)
        {
            StartDialogue();
        }
    }

    public void PlayerExitedRange()
    {
        Debug.Log("PlayerExitedRange() llamado");

        model.SetPlayerInRange(false);

        if (model.IsTalking)
        {
            EndDialogue();
        }
    }

    private void StartDialogue()
    {
        Debug.Log("Iniciando diálogo");

        if (model.DialogueLines.Count == 0)
        {
            Debug.Log("No hay líneas de diálogo, pero funciona");
        }

        model.SetTalking(true);
        currentLineIndex = 0;

        Debug.Log("NPC: " + model.NPCName);

        Invoke(nameof(NextLine), 2f);
    }

    private void NextLine()
    {
        currentLineIndex++;

        Debug.Log("Siguiente línea: " + currentLineIndex);

        if (currentLineIndex >= model.DialogueLines.Count)
        {
            Debug.Log("Fin del diálogo");
            EndDialogue();
            return;
        }

        Invoke(nameof(NextLine), 2f);
    }

    private void EndDialogue()
    {
        Debug.Log("Cerrando diálogo");

        model.SetTalking(false);
    }
}