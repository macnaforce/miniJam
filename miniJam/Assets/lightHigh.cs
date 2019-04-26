using UnityEngine;

public class lightHigh : MonoBehaviour
{
    public Light boatlight;

    private void OnTriggerEnter(Collider other)
    {
        boatlight.intensity = 1.5f;
    }

    private void OnTriggerExit(Collider other)
    {
        boatlight.intensity = 1f;
    }

}
