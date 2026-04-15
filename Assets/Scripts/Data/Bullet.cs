using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Logic(float speed)
    {
        rb.AddForce(transform.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
