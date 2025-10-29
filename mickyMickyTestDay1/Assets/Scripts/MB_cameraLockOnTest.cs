using UnityEngine;

public class MB_cameraLockOnTest : MonoBehaviour
{
    public Transform pTwoTarget;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (pTwoTarget != null)
        {
            transform.LookAt(pTwoTarget.position);
        }
       
    }
}
