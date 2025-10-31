using Unity.VisualScripting;
using UnityEngine;

public class MB_cbRigidBody : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {

        print("cannon ball hit object");
    }

    private void OnTriggerEnter(Collider other)
    {
            Destroy(this.gameObject);
    }


}
