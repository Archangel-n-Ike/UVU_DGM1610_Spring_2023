using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehavoir : MonoBehaviour
{
    public Text label;
    public FloatData dataObj;

    public void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel ()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
