using UnityEngine;

public class MB_playerHP : MonoBehaviour
{
    public int pOneHp;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pOneHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Player 1 is hit");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cannonBall"))
        {
            print(pOneHp);
            pOneHp -= 1;

        }
    }
}
