using UnityEngine;

public class EnergySaver : MonoBehaviour
{
    private int originalFrameRate = 120;
    private int lowPowerFrameRate = 30;

    void Start()
    {
        originalFrameRate = Application.targetFrameRate;
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            Application.targetFrameRate = originalFrameRate;
        }
        else
        {
            Application.targetFrameRate = lowPowerFrameRate;
        }
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            Application.targetFrameRate = lowPowerFrameRate;
        }
        else
        {
            Application.targetFrameRate = originalFrameRate;
        }
    }
}
