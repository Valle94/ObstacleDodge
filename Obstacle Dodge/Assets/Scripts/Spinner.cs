using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Variables for choosing what axis to rotate on and how fast
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        // Multiply angles by Time.deltaTime
        float xRotate = xAngle * Time.deltaTime;
        float yRotate = yAngle * Time.deltaTime;
        float zRotate = zAngle * Time.deltaTime;
        // Rotate the spinner
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
