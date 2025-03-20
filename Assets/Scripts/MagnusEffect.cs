using UnityEngine;

public class MagnusEffect : MonoBehaviour
{

    [SerializeField] Vector3 velocity, spin;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
            ApplyMagnusEffect();
        }
        
    }

    void Kick()
    {
        rb.angularVelocity = spin;  // Spinning
        rb.linearVelocity = velocity; //kick stright
    }    
    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        rb.AddForce(magnusForce,ForceMode.Force);
    }    

}
