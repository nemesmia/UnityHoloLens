using UnityEngine;

public class PlaySoundScript : MonoBehaviour {
    public AudioClip MyAudioFile;

    public void PlaySound()
    {
        GetComponent<AudioSource>().PlayOneShot(MyAudioFile);
    }
}
