using UnityEngine;

public class EnemyTraceController : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float raycastDistance = 2f;
    public float traceDistance = 2f;

    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector2 direction = player.position - transform.position;

        if (direction.magnitude > traceDistance)
            return;

        Vector2 directionNormalized = direction.normalized;

        RaycastHit2D[] hits = Physics2D.RaycastAll(
            transform.position,
            directionNormalized,
            raycastDistance
        );

        Debug.DrawRay(transform.position, directionNormalized * raycastDistance, Color.red);

        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider != null && hit.collider.CompareTag("Obstacle"))
            {
                Vector3 alternativeDirection = Quaternion.Euler(0, 0, -90f) * direction;
                transform.Translate(alternativeDirection.normalized * moveSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}