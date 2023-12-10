using UnityEngine;

public class Pchila : MonoBehaviour
{
    public AudioSource vic;
    public AudioSource vkl;
    public float Hp = 3f;
    public float speed;
    public Transform target;
    private bool igincol;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pula")
        {
            Hp -= 1f;
        }
        if (other.tag == "igrok")
        {
            igincol = true;
            vic.Stop();
            vkl.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "igrok")
        {
            igincol=false;
            vic.Play();
            vkl.Stop();
        }
    }
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("igrok").GetComponent<Transform>();
    }
    private void Update()
    {
        if (igincol)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if (Hp == 0f)
        {
            Destroy(this.gameObject);
        }   
    }
}
