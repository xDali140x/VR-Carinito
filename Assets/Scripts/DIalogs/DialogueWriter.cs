using TMPro;
using UnityEngine;
using System.Collections;

public class DialogueWriter : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;  // El componente de texto donde se muestra el diálogo
    [SerializeField] private float typingSpeed =    1f;  // La velocidad de escritura (ajusta según sea necesario)

    public void WriteDialogue(string dialogue)
    {
        StartCoroutine(TypeText(dialogue));  // Comienza el proceso de "escribir" el diálogo
    }

    private IEnumerator TypeText(string dialogue)
    {
        dialogueText.text = "";  // Limpia el texto actual
        foreach (char letter in dialogue)
        {
            dialogueText.text += letter;  // Agrega una letra a la vez
            yield return new WaitForSeconds(typingSpeed);  // Espera un tiempo antes de agregar la siguiente letra
        }
    }
}