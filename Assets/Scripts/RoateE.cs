using UnityEngine;

public class RoateE : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] Vector3 angularV, torqueV;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
          rb.angularVelocity = angularV;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            rb.AddTorque(torqueV);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
