using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oryzie2 : MonoBehaviour
{

    public int e;
    public int w;
    public int s;
    public int q;
    public int q1;
    public int a;
    public int a2;
    public int a1;
    public GameObject poloska;
    public GameObject pulya;
    public GameObject dulo;

    void Update()
    {
        if(s == 1)
        {
            a2 = a1;
        }
        if (s == 0)
        {
            if (a1 == 0)
            {
                a2 = 1;
            }
            if (a1 == 1)
            {
                a2 = 0;
            }
        }
        if (q1 == 1)
        {
            if(a2 == 1)
            {
                if(e == 1)
                {
                    if (a == 0)
                    {
                        print("אכאץמדבאנננננננ");
                    }
                    if (a == 1)
                    {
                        Instantiate(pulya, dulo.transform.position, dulo.transform.rotation);
                        poloska.GetComponent<strelba>().kd = 0;
                        poloska.GetComponent<strelba>().nach_vr = 0;
                        a = 0;
                    }
                }
            }
        }
        if (q1 != 1)
        {
            if (a2 != 1)
            {
                if (e != 1)
                {
                    if (a == 0)
                    {
                        print("אכאץמדבאנננננננ");
                    }
                    if (a == 1)
                    {
                        Instantiate(pulya, dulo.transform.position, dulo.transform.rotation);
                        poloska.GetComponent<strelba>().kd = 0;
                        poloska.GetComponent<strelba>().nach_vr = 0;
                        a = 0;
                    }
                }
            }
        }
        a1 = 0;
        if (w == 0)
        {
            if (a == 0)
            {
                q1 = 1;
            }
            if (a == 1)
            {
                q1 = 0;
            }
        }
        if (w == 1)
        {
            if (a == 0)
            {
                q1 = 0;
            }
            if (a == 1)
            {
                q1 = 1;
            }
        }
    }
}
