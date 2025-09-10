using UnityEngine;

public class Roller : MonoBehaviour
{
    [SerializeField] float rollSpeed = 0;

    void Update()
    {
        transform.Translate(0, 0, rollSpeed);
        ChangeDirection();
    }

    void ChangeDirection()
    {
        if (gameObject.transform.position.z > 15 || gameObject.transform.position.z < -15)
        {
            rollSpeed *= -1; // Multiple by -1 to reverse direction
        }
    }
}
