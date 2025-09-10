using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.aquamarine;
        Debug.Log("Something hit me!");
    }
}
