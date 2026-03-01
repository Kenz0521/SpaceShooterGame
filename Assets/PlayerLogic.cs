using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float speed = 8f;

    public GameObject projectilePrefab;

    public Transform firePoint;

    void Update()
    {
        float move =
            Input.GetAxis("Horizontal");

        transform.Translate(
            Vector2.right * move *
            speed *
            Time.deltaTime
        );

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(
                projectilePrefab,
                firePoint.position,
                Quaternion.identity
            );
        }
    }
}
