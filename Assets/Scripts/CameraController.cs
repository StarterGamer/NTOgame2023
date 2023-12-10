using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform pTrans;
    public Vector3 offset;
    public float camPosSpeed = 5f;

    void FixedUpdate()
    {
        Vector3 newCamPos = new Vector3(offset.x, pTrans.position.y + offset.y, pTrans.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, newCamPos, camPosSpeed * Time.deltaTime);
    }
}

