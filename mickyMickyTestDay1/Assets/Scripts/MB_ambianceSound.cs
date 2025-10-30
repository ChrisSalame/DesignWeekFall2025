using UnityEngine;

public class MB_ambianceSound : MonoBehaviour
{

    public AudioSource ambiance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ambiance.Play();
    }

}
