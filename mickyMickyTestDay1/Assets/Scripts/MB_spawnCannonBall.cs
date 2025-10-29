using UnityEngine;

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

        if (Input.GetKeyDown("f"))
        {

            GameObject gO = Instantiate(cannonBalls);
            gO.transform.position = transform.position;
            gO.transform.rotation = transform.rotation;
            gO.SetActive(true);
        
        }

    }
}
