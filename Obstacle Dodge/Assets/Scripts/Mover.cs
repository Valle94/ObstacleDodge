using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to Obstacle Dodge!");
        Debug.Log("Use WASD or the the arrow keys to move.");
        Debug.Log("Don't touch the walls or obstacales!");
    }

}
