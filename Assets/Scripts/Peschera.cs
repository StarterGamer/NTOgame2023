using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peschera : MonoBehaviour
{

    public GameObject skala;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "igrok")
        {
            skala.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "igrok")
        {
            skala.SetActive(true);
        }
    }
}
