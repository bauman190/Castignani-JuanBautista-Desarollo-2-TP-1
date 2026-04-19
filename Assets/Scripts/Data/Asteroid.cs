using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Asteroid : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        Movement();
    }


    private void Movement()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
