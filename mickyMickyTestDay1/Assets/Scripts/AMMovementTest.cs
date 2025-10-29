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
        if (paddle.transform.rotation.y * Mathf.Rad2Deg > -60 && paddle.transform.rotation.y * Mathf.Rad2Deg < 60)
            Debug.Log(paddle.transform.rotation.y * Mathf.Rad2Deg);

        if (paddle.transform.localRotation.y * Mathf.Rad2Deg > prevRotation)
        {
            rb.AddForce(transform.forward * Time.deltaTime * 300, ForceMode.Acceleration);
            
        }
        rb.linearVelocity *= 0.995f;
        prevRotation = paddle.transform.localRotation.y;
    }
}
