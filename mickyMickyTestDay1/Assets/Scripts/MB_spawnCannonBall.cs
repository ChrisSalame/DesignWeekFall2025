using UnityEngine;
using UnityEngine.Assertions.Must;

public class MB_spawnCannonBall : MonoBehaviour
{
    public GameObject cannonBalls;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha5))
        {

            GameObject gO = Instantiate(cannonBalls);
            gO.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z +1);
            gO.transform.rotation = transform.rotation;
            gO.SetActive(true);
        
        }

    }
}
