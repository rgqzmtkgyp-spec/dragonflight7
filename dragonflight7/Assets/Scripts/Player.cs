using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Start()
    {
        
    }

    
    void Update()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(distanceX, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy" && collision.tag == "Enemy2")
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);
        } 
    }
}
