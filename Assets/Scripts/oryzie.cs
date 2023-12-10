using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oryzie : MonoBehaviour
{

    public GameObject panel;
    public GameObject pest;
    public GameObject yd;
    public GameObject strelba;
    public GameObject nestrelba;
    public GameObject im;
    public GameObject p1;
    public GameObject p2;
    public int q;

    public void ydol()
    {
        Destroy(yd.gameObject);
    }
    public void vklych()
    {
        panel.SetActive(true);
    }
    public void viklych()
    {
        panel.SetActive(false);
    }
    public void strel()
    {
        var w = Instantiate(strelba, im.transform.position, im.transform.rotation);
        w.transform.SetParent(im.transform);
        panel.SetActive(false);
        if (q == 1)
        {
            pest.GetComponent<oryzie2>().e = 1;
        }
    }
    public void nestrel()
    {
        var w = Instantiate(nestrelba, im.transform.position, im.transform.rotation);
        w.transform.SetParent(im.transform);
        panel.SetActive(false);
        if (q == 1)
        {
            pest.GetComponent<oryzie2>().e = 0;
        }
    }
    public void knopka()
    {
        if (q == 1)
        {
            p1.SetActive(false);
            pest.GetComponent<oryzie2>().w = 1;
        }
        else
        {
            p1.SetActive(false);
            pest.GetComponent<oryzie2>().s = 0;
        }
    }
    public void perezaradka()
    {
        if (q == 1)
        {
            p2.SetActive(false);
            pest.GetComponent<oryzie2>().w = 0;
        }
        else
        {
            p2.SetActive(false);
            pest.GetComponent<oryzie2>().s = 1;
        }
    }
}
