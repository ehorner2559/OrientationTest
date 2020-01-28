using UnityEngine;
using TMPro;

public class OrientationView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textField = null;

    private void Update()
    {
        textField.text = Input.deviceOrientation.ToString();
    }
}
