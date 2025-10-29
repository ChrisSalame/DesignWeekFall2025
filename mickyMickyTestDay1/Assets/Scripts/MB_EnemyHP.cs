using UnityEngine;

public class MB_EnemyHP : MonoBehaviour
{
    public int pTwoHp;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pTwoHp <= 0) 
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Player 2 is hit");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cannonBall"))
        {
            print(pTwoHp);
            pTwoHp -= 1;

        }
    }

}
