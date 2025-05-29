using UnityEngine;

public class CarColorChanger : MonoBehaviour
{
    private Renderer carRenderer;

    void Start()
    {
        carRenderer = GetComponentInChildren<Renderer>(); // finds MeshRenderer automatically

        if (carRenderer == null)
        {
            Debug.LogError("❌ Renderer not found on CarColorChanger object or children!");
        }
    }

    public void SetBlackColor()
    {
        if (carRenderer != null)
            carRenderer.material.color = Color.black;
    }

    public void SetRedColor()
    {
        if (carRenderer != null)
            carRenderer.material.color = Color.red;
    }

    public void SetBlueColor()
    {
        if (carRenderer != null)
            carRenderer.material.color = Color.blue;
    }

    public void SetWhiteColor()
    {
        if (carRenderer != null)
            carRenderer.material.color = Color.white;
    }
}
