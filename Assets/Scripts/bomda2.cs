using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bomda2 : MonoBehaviour
{
    public int q = -1;
    public int w;
    public int a = -1;
    public int s;
    public int e;
    public GameObject knop;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pchila")
        {
            if(w == 1)
            {
                q = 1;
            }
            if (w == 0)
            {
                q = 0;
            }
        }
        if (other.gameObject.tag == "igrok")
        {
            knop.SetActive(true);
            if (s == 1)
            {
                a = 1;
            }
            if (s == 0)
            {
                a = 0;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "pchila")
        {
            if (w == 1)
            {
                q = 0;
            }
            if (w == 0)
            {
                q = 1;
            }
        }
        if (other.gameObject.tag == "igrok")
        {
            knop.SetActive(false);
            if (s == 1)
            {
                a = 0;
            }
            if (s == 0)
            {
                a = 1;
            }
        }
    }
    private void Update()
    {
        if(q == 1)
        {
            if(a == 1)
            {
                if(e == 1)
                {
                    print("взрыв");
                }
            }
        }
        if (q != 1)
        {
            if (a != 1)
            {
                if (e == 0)
                {
                    print("взрыв");
                }
            }
        }
    }
}
