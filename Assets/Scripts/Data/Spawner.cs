using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Asteroid prefabAsteroid;
    [SerializeField] private float coolDown = 10f;
    [SerializeField] private Transform player;

    private float timer = 0;

    private void Update()
    {
        SpawnLogic();
    }
    private void SpawnLogic()
    {
        timer += Time.deltaTime;
        if(timer >= coolDown)
        {
            Spawn();
            timer = 0;
        }
    }
    private void Spawn()
    {
        Asteroid asteroid = Instantiate(prefabAsteroid, transform.position, Quaternion.identity);
        asteroid.SetTarget(player);
    }
}
