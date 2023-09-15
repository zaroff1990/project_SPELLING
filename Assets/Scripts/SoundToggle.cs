using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public Image spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite soundOnSprite; // Sprite when sound is on
    public Sprite soundOffSprite; // Sprite when sound is off

    public void ToggleSound()
    {
        if (audioSource.isPlaying) // Check if sound is currently playing
        {
            audioSource.Stop(); // Stop the sound
            spriteRenderer.sprite = soundOffSprite; // Change to 'sound off' graphic
        }
        else
        {
            audioSource.Play(); // Play the sound
            spriteRenderer.sprite = soundOnSprite; // Change to 'sound on' graphic
        }
    }
    private void Start()
    {
        if (!audioSource.isPlaying) // Check if sound is currently playing
        {
            spriteRenderer.sprite = soundOffSprite; // Change to 'sound off' graphic
        }
        else
        {
            spriteRenderer.sprite = soundOnSprite; // Change to 'sound on' graphic
        }
    }
}