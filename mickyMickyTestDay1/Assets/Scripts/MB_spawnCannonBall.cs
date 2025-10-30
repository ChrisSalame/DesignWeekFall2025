using UnityEngine;
using UnityEngine.Assertions.Must;

public class MB_spawnCannonBall : MonoBehaviour
{
    public GameObject cannonBalls;
    public AudioSource cannonBallFired;
    public KeyCode inputType; 

    void Update()
    {
        
        if (Input.GetKeyUp(inputType) || Input.GetKeyDown(inputType))
        {
            GameObject gO = Instantiate(cannonBalls);
            gO.transform.position = new Vector3 (transform.position.x , transform.position.y, transform.position.z);
            gO.transform.rotation = transform.rotation;
            gO.SetActive(true);

            cannonBallFired.Play();
        
        }

    }
}
