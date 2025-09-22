using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // When objects are touched by the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // They change color and become "Hit"
            GetComponent<MeshRenderer>().material.color = Color.aquamarine;
            gameObject.tag = "Hit";
        }
    }
}
