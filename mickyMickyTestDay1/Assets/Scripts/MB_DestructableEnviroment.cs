using Unity.VisualScripting;
using UnityEngine;

public class MB_DestructableEnviroment : MonoBehaviour
{
    public int rockHP;
    public AudioSource cannonBallFireHit;
    //public AudioSource audioSource;
    //public AudioClip cannonBallDestroy;

    private void Start()
    {
        //Scrapped audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (rockHP <= 0)
        {
            //Scrapped audioSource.PlayOneShot(cannonBallDestroy, 1f);
            //Does not sound on destroy, cannonBallFireHit.Play();
            print("rock is destroyed");
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cannonBall"))
        {
            print("rock is hit");
            cannonBallFireHit.Play();
            print(rockHP);
            rockHP -= 3;

        }
    }
}
