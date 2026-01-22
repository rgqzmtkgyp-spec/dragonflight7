using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float moveSpeed = 1.4f;
    public GameObject effect;

    void Start()
    {
        
    }

    
    void Update()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, -distanceY, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            SoundManager.instance.SoundDie();
            GameManager.instance.AddScore(100);

            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
