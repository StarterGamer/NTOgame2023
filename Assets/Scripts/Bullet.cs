using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float speedOfRot;
    public LayerMask mask;
    public GameObject cub;
    public GameObject cub2;

    private void Update()
    {
        cub.transform.Rotate(0, 0, speedOfRot);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "zem")
        {
            Destroy(cub2.gameObject);
        }
        else if(other.gameObject.tag == "pchila")
            {
                Destroy(cub2.gameObject);
            }

    }
}

