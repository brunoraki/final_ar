using UnityEngine;

public class CarEngineStarter : MonoBehaviour
{
    public AudioSource engineSound;

    public void StartEngine()
    {
        if (!engineSound.isPlaying)
            engineSound.Play();
    }

    public void StopEngine()
    {
        if (engineSound.isPlaying)
            engineSound.Stop();
    }
}
