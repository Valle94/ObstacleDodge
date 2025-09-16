using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject gameObject in projectiles)
            {
                if (gameObject != null)
                {
                    gameObject.SetActive(true);
                }
            }
        }
    }
}
