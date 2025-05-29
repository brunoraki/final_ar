using UnityEngine;

public class HeadlightController : MonoBehaviour
{
    public Light headlight;
    private bool isOn = false;

    public void ToggleHeadlight()
    {
        isOn = !isOn;
        headlight.enabled = isOn;
    }
}
