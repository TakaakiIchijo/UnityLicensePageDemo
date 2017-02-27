using UnityEngine;

public class TitleMenuController : MonoBehaviour
{
    public Canvas licenseCanvas;

    private void Start()
    {
        HideLicenseCanvas();
    }

    public void ShowLicenseCanvas()
    {
        licenseCanvas.enabled = true;
    }

    public void HideLicenseCanvas()
    {
        licenseCanvas.enabled = false;
    }
}