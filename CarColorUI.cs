using UnityEngine;

public class CarColorUI : MonoBehaviour
{
    public CarColorChanger carColorChanger; // Drag the instance after it's spawned!

    public void SetColorBlack()
    {
        if (carColorChanger != null)
            carColorChanger.SetBlackColor();
    }

    public void SetColorRed()
    {
        if (carColorChanger != null)
            carColorChanger.SetRedColor();
    }

    public void SetColorWhite()
    {
        if (carColorChanger != null)
            carColorChanger.SetWhiteColor();
    }

    public void SetColorBlue()
    {
        if (carColorChanger != null)
            carColorChanger.SetBlueColor();
    }
}
