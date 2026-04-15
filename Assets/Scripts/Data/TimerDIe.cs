using UnityEngine;

public class TimerDIe : MonoBehaviour
{
    [SerializeField] private float timer;
    void Update()
    {
        Destroy(gameObject, timer);
    }
}
