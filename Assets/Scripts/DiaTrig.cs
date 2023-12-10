using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaTrig : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDia(dialogue);
    }
}
