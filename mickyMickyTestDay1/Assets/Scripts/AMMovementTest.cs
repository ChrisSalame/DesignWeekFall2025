using UnityEngine;

public class AMMovementTest : MonoBehaviour
{
    public GameObject paddle;
    public float prevRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (paddle.transform.rotation.y > prevRotation)
        {
            transform.position += transform.forward * Time.deltaTime;
        }
        prevRotation = paddle.transform.rotation.y;
    }
}
