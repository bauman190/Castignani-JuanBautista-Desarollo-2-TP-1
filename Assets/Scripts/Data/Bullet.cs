using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] AudioSource AS;
    [SerializeField] GameObject prefabParticles;

    public void Awake()
    {
        AS = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
       AS.Play();
    }
    public void Logic(float speed)
    {
        rb.AddForce(transform.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        var particle = Instantiate(prefabParticles, transform.position, Quaternion.identity);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
