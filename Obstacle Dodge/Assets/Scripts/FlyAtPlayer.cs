using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 1f;
    Vector3 playerPosition;

    void Awake()
    {
        // Start with projectiles disabled
        gameObject.SetActive(false);
    }

    void Start()
    {
        // When they projectiles are enabled, get player position
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    // Move the projectile from it's starting pos to player pos
    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(
                    transform.position,
                    playerPosition,
                    speed * Time.deltaTime);
    }

    // Once the object reaches where the player was, destroy it
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
