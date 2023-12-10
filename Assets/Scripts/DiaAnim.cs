using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaAnim : MonoBehaviour
{
    public Animator startAnim;
    public DialogueManager dm;

    public void OnTriggerEnter(Collider other)
    {
        startAnim.SetBool("StartOpen", true);
    }

    public void OnTriggerExit(Collider other)
    {
        startAnim.SetBool("StartOpen", false);
        dm.End();
    }
}
