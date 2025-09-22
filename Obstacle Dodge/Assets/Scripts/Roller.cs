using System.IO.Compression;
using Mono.Cecil.Cil;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Roller : MonoBehaviour
{
    // Fields for rolling speed and how far to move them
    [SerializeField] float rollSpeed = 0;
    [SerializeField] int rollDistance = 15;

    Vector3 startPosition;

    void Start()
    {
        // Initialize start position as the roller's position in the world
        startPosition = gameObject.transform.position;
    }

    void Update()
    {
        Roll();
    }

    void Roll()
    {
        // Roll along the local z axis at specified speed
        transform.Translate(0, 0, rollSpeed * Time.deltaTime);

        // This if-statement checks if the object is positioned to move
        // along the world x-axis or z-axis by checking it's y-rotation
        if (gameObject.transform.rotation.y == 0)
        {
            // When the object reaches the bounds of it's roll distance
            if (gameObject.transform.position.z > startPosition.z + rollDistance
            || gameObject.transform.position.z < startPosition.z - rollDistance)
            {
                rollSpeed *= -1; // Multiple by -1 to reverse direction
            }
        }
        else
        {
            // When the object reaches the bounds of it's roll distance            
            if (gameObject.transform.position.x > startPosition.x + rollDistance
               || gameObject.transform.position.x < startPosition.x - rollDistance)
            {
                rollSpeed *= -1; // Multiple by -1 to reverse direction
            }
        }
            
    }
}
