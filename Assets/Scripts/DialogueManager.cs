using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI diaText;
    public TextMeshProUGUI nameText;

    public Animator boxAnim;
    public Animator StartAnim;

    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDia(Dialogue dialogue)
    {
        boxAnim.SetBool("BoxOpen", true);
        StartAnim.SetBool("StartOpen", false);

        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DispNextSent();
    
    }

    public void DispNextSent()
    {
        if (sentences.Count == 0)
        {
            End();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        diaText.text ="";
        foreach(char letter in sentence.ToCharArray())
        {
            diaText.text += letter;
            yield return null;
        }
    }

    public void End()
    {
        boxAnim.SetBool("BoxOpen", false) ;
    }

}
