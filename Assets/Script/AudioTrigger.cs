using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to this object
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the Player tag
        if (other.CompareTag("Player"))
        {
            // Play the audio when the player enters the trigger
            audioSource.Play();
        }
    }
    private void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
        audioSource.Stop();
    }
}
}
