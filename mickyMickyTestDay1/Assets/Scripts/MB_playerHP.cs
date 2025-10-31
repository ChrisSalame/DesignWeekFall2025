using TMPro;
using UnityEngine;

public class MB_playerHP : MonoBehaviour
{
    public int pOneHp;
    public TextMeshProUGUI tmp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tmp.text = pOneHp.ToString();
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
            tmp.text = pOneHp.ToString();
        }
    }
}
