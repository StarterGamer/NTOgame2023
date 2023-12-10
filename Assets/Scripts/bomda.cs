using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomda : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public void Vklychi3()
    {
        panel3.SetActive(true);
        panel2.SetActive(false);
        panel1.SetActive(false);
    }
    public void Vklychi2()
    {
        panel3.SetActive(false);
        panel2.SetActive(true);
        panel1.SetActive(false);
    }
    public void Vklychi1()
    {
        panel3.SetActive(false);
        panel2.SetActive(false);
        panel1.SetActive(true);
    }
    public void viklychi()
    {
        panel3.SetActive(false);
        panel2.SetActive(false);
        panel1.SetActive(false);
    }
}
