using UnityEngine;

[RequireComponent(typeof(NPCModel))]
public class NPCController : MonoBehaviour
{
    private NPCModel model;

    [SerializeField] private NPCView view;  // Referencia a NPCView (configurada en el Inspector)
    private int currentLineIndex = 0;

    [SerializeField] private Camera playerCamera;  // Referencia a la cámara del jugador

    [SerializeField] private float timeBetweenLines = 3f;  // Tiempo entre cada línea de diálogo (en segundos)
    private float timer;  // Temporizador para avanzar el diálogo

    private void Awake()
    {
        model = GetComponent<NPCModel>();

        // Verifica si el view está asignado
        if (view == null)
        {
            Debug.LogError("NPCView no está asignado en el Inspector.");
        }
    }

    // Método que se llama cuando el jugador entra en el rango del NPC
    public void PlayerEnteredRange()
    {
        model.SetPlayerInRange(true);  // El jugador está en el rango del NPC

        if (!model.IsTalking)
        {
            StartDialogue();  // Iniciar el diálogo con el NPC
        }

        // Activar el Canvas de diálogo (solo el Panel)
        view.ShowDialogue();  // Solo activamos el panel de diálogo

        // Actualizar el nombre del NPC en el Canvas
        view.UpdateNPCName(model.NPCName);  // Mostrar el nombre del NPC
    }

    // Iniciar el diálogo con el NPC
    private void StartDialogue()
    {
        if (model.DialogueLines.Count == 0) return;

        model.SetTalking(true);  // El NPC está hablando
        currentLineIndex = 0;    // Comenzamos con la primera línea de diálogo
        timer = timeBetweenLines;  // Reiniciar el temporizador
        view.UpdateDialogueText(model.DialogueLines[currentLineIndex].text);  // Mostrar la primera línea
    }

    // Avanzar al siguiente diálogo cuando el temporizador termine
    private void Update()
    {
        if (model.IsTalking)
        {
            // Contar el tiempo para avanzar el diálogo
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                NextLine();  // Avanzar a la siguiente línea de diálogo
                timer = timeBetweenLines;  // Reiniciar el temporizador para la siguiente línea
            }
        }
    }

    // Avanzar al siguiente diálogo
    private void NextLine()
    {
        currentLineIndex++;

        if (currentLineIndex >= model.DialogueLines.Count)
        {
            EndDialogue();  // Si se terminó el diálogo, lo finalizamos
            return;
        }

        // Actualizar el texto del diálogo
        view.UpdateDialogueText(model.DialogueLines[currentLineIndex].text);  // Actualizar el diálogo
    }

    // Terminar el diálogo
    private void EndDialogue()
    {
        model.SetTalking(false);  // El NPC deja de hablar
        view.HideDialogue();  // Ocultar el Panel de diálogo

        // Lógica para desbloquear la escena o cambiarla
        view.UnlockScene();  // Por ejemplo, cambiar de escena
    }
}