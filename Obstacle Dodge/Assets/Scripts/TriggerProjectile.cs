using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    // Serialized an empty array of projectile game objects
    [SerializeField] GameObject[] projectiles;

    void OnTriggerEnter(Collider other)
    {
        // When the player hits the trigger zone
        if (other.CompareTag("Player"))
        {
            // Enable each projectile in the array
            foreach (GameObject gameObject in projectiles)
            {
                if (gameObject != null)
                {
                    gameObject.SetActive(true);
                }
            }
        }
        // After each object has been enabled, destroy the zone
        Destroy(gameObject);
    }
}
