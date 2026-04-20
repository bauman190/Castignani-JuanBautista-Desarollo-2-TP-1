using UnityEngine;


public class PlanetBehaviour : MonoBehaviour
{
    [SerializeField]  private Transform target;
    [SerializeField]  private float baseSpeed = 10f;
    [SerializeField]  private AudioSource AS;
    [SerializeField]  private PlayDestroySound prefabDestroySound;

    private float radius;
    private float speed = 0f;
    [SerializeField] private float spinSpeed = 50f;

    private void Awake()
    {
        AS = GetComponent<AudioSource>();
    }
    private void Start()
    {
        radius = Vector3.Distance(transform.position, target.position);
        speed = (baseSpeed / radius) * Time.deltaTime;
        spinSpeed = spinSpeed / radius;
    }

   
    private void Update()
    {
        transform.RotateAround(target.position, Vector3.up, speed);
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime, Space.Self);
    }
    private void OnDestroy()
    {
        PlayDestroySound destoySound = Instantiate(prefabDestroySound, transform.position, Quaternion.identity);
    }
}
