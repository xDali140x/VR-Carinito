using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueLine
{
    public string speakerName;
    [TextArea(2, 4)] public string text;
}

public class NPCModel : MonoBehaviour
{
    [Header("Datos del NPC")]
    [SerializeField] private string npcName;
    [SerializeField] private List<DialogueLine> dialogueLines = new List<DialogueLine>();

    public string NPCName => npcName;
    public List<DialogueLine> DialogueLines => dialogueLines;

    public bool PlayerInRange { get; private set; }
    public bool IsTalking { get; private set; }

    public void SetPlayerInRange(bool value)
    {
        PlayerInRange = value;
    }

    public void SetTalking(bool value)
    {
        IsTalking = value;
    }
}