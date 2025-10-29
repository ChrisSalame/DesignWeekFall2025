using UnityEngine;

public class MB_DestructableEnviroment : MonoBehaviour
{
    public int rockHP;

    void Update()
    {
        if (rockHP <= 0)
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
            print(rockHP);
            rockHP -= 3;

        }
    }
}
