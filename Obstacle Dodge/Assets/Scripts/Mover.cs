using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8f;
    [SerializeField] float mouseXSensitivity = 100f;
    [SerializeField] Transform playerBody;

    void Start()
    {
        PrintInstructions();
        // Set mouse cursor to lock to screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Get keyboard inputs for left/right, forward/backward, and mouse
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * mouseXSensitivity * Time.deltaTime;

        // Translate/Rotate the player based on inputs
        transform.Translate(xValue, yValue, zValue);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to Obstacle Dodge!");
        Debug.Log("Use WASD or the the arrow keys to move.");
        Debug.Log("Move the mouse to rotate the player.");
        Debug.Log("Don't touch the walls or obstacles!");
    }
}
