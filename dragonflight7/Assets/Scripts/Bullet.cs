using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1f;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
