using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 1f);
    }

    
    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
