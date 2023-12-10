using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 10f;
    private Animator anim;
    private Rigidbody rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float JumpForce = 2f;
    public Joystick joystick;
    private float timebtwjumps;
    public float starttimebtwjumps;
    public bool IsLeft;
    public int hp;
    public GameObject por;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(hp <= 0)
        {
            Die();
        }
        float h = joystick.Horizontal;
        Vector3 dvector = new Vector3(0, 0, h);
        if (dvector.magnitude > Mathf.Abs(0.05f))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dvector), Time.deltaTime * rotationSpeed);
        }


        anim.SetFloat("Speed", Vector3.ClampMagnitude(dvector, 1).magnitude);
        Vector3 moveDir = Vector3.ClampMagnitude(dvector, 1) * speed;
        rb.velocity = new Vector3(moveDir.x, rb.velocity.y, moveDir.z);
        rb.angularVelocity = Vector3.zero;

        if (joystick.Vertical>0.6 && Physics.Raycast(groundCheck.position, Vector3.down, 0.3f, groundLayer) && timebtwjumps <= 0)
        {
            Jump();
        }



        if (Physics.Raycast(groundCheck.position, Vector3.down, 0.3f, groundLayer))
        {
            anim.SetBool("IsinAir", false);
        }
        else
        {
            anim.SetBool("IsinAir", true);
        }


        timebtwjumps -= Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "pchila")
        {
            hp -= 1;
        }
    }
    void Jump()
    {
        anim.SetTrigger("Jump");
        rb.AddForce(Vector2.up * JumpForce, ForceMode.Impulse);
        timebtwjumps = starttimebtwjumps;
    }
    public void Die()
    {
        Destroy(this.gameObject);
        por.SetActive(true);
        Time.timeScale = 0f;
    }
}
