using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class strelba : MonoBehaviour
{

    public int kd;
    public GameObject pest;
    public float nach_vr;
    public float con_vr;
    public Image poloska;

    public void ogon()
    {
        pest.GetComponent<oryzie2>().a1 = 1;
        kd = 0;
        nach_vr = 0;
    }
    void Update()
    {
        pest.GetComponent<oryzie2>().a = kd;
        if (kd != 1)
        {
            nach_vr += Time.deltaTime;
            poloska.fillAmount = nach_vr;
            if (nach_vr >= con_vr)
            {
                kd = 1;
                pest.GetComponent<oryzie2>().a = kd;
            }
        }
    }
}
