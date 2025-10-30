using UnityEngine;
using UnityEngine.Assertions.Must;

public class MB_spawnCannonBall : MonoBehaviour
{
    public GameObject cannonBalls;
    public AudioSource cannonBallFired;

    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            GameObject gO = Instantiate(cannonBalls);
            gO.transform.position = new Vector3 (transform.position.x , transform.position.y, transform.position.z);
            gO.transform.rotation = transform.rotation;
            gO.SetActive(true);

            cannonBallFired.Play();
        
        }

    }
}
