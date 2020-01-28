using UnityEngine;
using UnityEngine.iOS;
using TMPro;

public class OrientationView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI orientation = null;

    [SerializeField]
    private TextMeshProUGUI device = null;

    private void Awake()
    {
        device.text = Device.generation.ToString();
    }

    private void Update()
    {
        orientation.text = Input.deviceOrientation.ToString();
    }
}
