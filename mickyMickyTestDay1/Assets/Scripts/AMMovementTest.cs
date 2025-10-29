using UnityEngine;

public class AMMovementTest : MonoBehaviour
{
    public GameObject paddle;
    public float prevRotation;
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (paddle.transform.rotation.y > prevRotation)
        {
            rb.AddForce(transform.forward * Time.deltaTime * 300, ForceMode.Acceleration);
            transform.Rotate(0,Time.deltaTime * 30,0);
        }
        rb.linearVelocity *= 0.995f;
        prevRotation = paddle.transform.rotation.y;
    }
}
