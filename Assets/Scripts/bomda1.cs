using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomda1 : MonoBehaviour
{
    public GameObject igrok_dalnost;
    public GameObject pchela_dalnost;
    public GameObject im;
    public GameObject panel;
    public GameObject yd;
    public GameObject vtor;
    public GameObject perv;
    public GameObject prog;
    public GameObject bimba;
    public int q;

    public void igrok_radom()
    {
        var w = Instantiate(igrok_dalnost, im.transform.position, im.transform.rotation);
        w.transform.SetParent(im.transform);
        panel.SetActive(false);
        if(q == 1)
        {
            bimba.GetComponent<bomda2>().e = 1;
        }
    }
    public void pchela_radom()
    {
        var w = Instantiate(pchela_dalnost, im.transform.position, im.transform.rotation);
        w.transform.SetParent(im.transform);
        panel.SetActive(false);
        if (q == 1)
        {
            bimba.GetComponent<bomda2>().e = 0;
        }
    }
    public void ydol()
    {
        Destroy(yd.gameObject);
    }
    public void otk()
    {
        prog.SetActive(true);
    }
    public void zakr()
    {
        prog.SetActive(false);
        if (bimba.GetComponent<bomda2>().w == 1)
        {
            if (bimba.GetComponent<bomda2>().s == 0)
            {
                bimba.GetComponent<bomda2>().a = 1;
            }
        }
        if (bimba.GetComponent<bomda2>().w == 0)
        {
            if (bimba.GetComponent<bomda2>().s == 1)
            {
                bimba.GetComponent<bomda2>().q = 1;
            }
        }
        if (bimba.GetComponent<bomda2>().w == 0)
        {
            if (bimba.GetComponent<bomda2>().s == 0)
            {
                bimba.GetComponent<bomda2>().a = 1;
                bimba.GetComponent<bomda2>().q = 1;
            }
        }
    }
    public void ig_rad()
    {
        if(q == 1)
        {
            vtor.SetActive(false);
            bimba.GetComponent<bomda2>().w = 1;
        }
        else
        {
            vtor.SetActive(false);
            bimba.GetComponent<bomda2>().s = 1;
        }
    }
    public void ig_ne_rad()
    {
        if (q == 1)
        {
            perv.SetActive(false);
            bimba.GetComponent<bomda2>().w = 0;
        }
        else
        {
            perv.SetActive(false);
            bimba.GetComponent<bomda2>().s = 0;
        }
    }
}

