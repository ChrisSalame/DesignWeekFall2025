using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class MB_spawnCannonBall : MonoBehaviour
{
    public GameObject cannonBalls;
    public AudioSource cannonBallFired;
    public bool mousePress;
    public KeyCode inputType;
    public bool KeyUpOn;
    [SerializeField]
    private float reloadTimer;
    public Scrollbar scr;
    public ColorBlock col1, col2;

    void Update()
    {

        if (!mousePress)
        {
            if (((Input.GetKeyUp(inputType) && KeyUpOn) || Input.GetKeyDown(inputType)) && reloadTimer <= 0)
            {
                GameObject gO = Instantiate(cannonBalls);
                gO.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                gO.transform.rotation = transform.rotation;
                gO.SetActive(true);

                cannonBallFired.Play();

                reloadTimer = 1.4f;
            }
        }
        else
        {
            if (((Input.GetMouseButtonUp(0) && KeyUpOn) || Input.GetMouseButtonDown(0)) && reloadTimer <= 0)
            {
                GameObject gO = Instantiate(cannonBalls);
                gO.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                gO.transform.rotation = transform.rotation;
                gO.SetActive(true);

                cannonBallFired.Play();

                reloadTimer = 1.4f;
            }
        }

        if (reloadTimer > 0)
        {
            reloadTimer -= Time.deltaTime;
            scr.colors = col1;
            scr.size = (1.4f - reloadTimer) / 1.4f;
        }
        else
        {
            scr.colors = col2;
        }
    }
}
