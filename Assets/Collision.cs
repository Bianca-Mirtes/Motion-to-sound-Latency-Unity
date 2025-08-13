using UnityEngine;

public class Collision : MonoBehaviour
{
    public AudioClip clip;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
