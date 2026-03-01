using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;

    public int scoreValue = 10;

    void Update()
    {
        transform.Translate(
            Vector2.down *
            speed *
            Time.deltaTime
        );

        if (transform.position.y < -6)
        {
            GameManager.instance.GameOver();

            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile"))
        {
            GameManager.instance.AddScore(scoreValue);

            Destroy(other.gameObject);

            Destroy(gameObject);
        }
    }
}
