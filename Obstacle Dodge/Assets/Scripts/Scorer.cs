using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Initialize score
    int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        // When you hit an object that hasn't been "hit" before
        if (!collision.gameObject.CompareTag("Hit"))
        {
            // Increase score and print total score
            score++;
            Debug.Log($"You've bumped into something {score} times.");
        }
    }
}
