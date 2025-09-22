using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // User entered time to wait before dropping
    [SerializeField] float timeToWait = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    void Start()
    {
        // Initializing components and turning them off to start. 
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;

        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
    }

    void Update()
    {
        // Once enough time has passed
        if (Time.time >= timeToWait)
        {
            // Turn on the mesh renderer and enable gravity
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}
