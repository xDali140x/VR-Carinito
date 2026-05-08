using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class DialogueLine
{
    public string text;
}

public class NPCModel : MonoBehaviour
{
    public string NPCName; // Nombre del NPC
    public List<DialogueLine> DialogueLines; // Lista de diálogos de este NPC
    public bool IsTalking = false; // Si el NPC está hablando o no
    public bool PlayerInRange = false; // Si el jugador está cerca del NPC

    public void SetPlayerInRange(bool value)
    {
        PlayerInRange = value;
    }

    public void SetTalking(bool value)
    {
        IsTalking = value;
    }
}