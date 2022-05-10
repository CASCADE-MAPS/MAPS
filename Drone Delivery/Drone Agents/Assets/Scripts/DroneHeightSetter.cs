using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DroneHeightSetter : MonoBehaviour
{
    public Transform origin;
    float height;
    public static float DroneHeight;
    public Slider slider;
    public TextMeshProUGUI text;

    public void SetHeight()
    {
        height = slider.value;
        DroneHeight = height + origin.position.y;
        text.text = "Drone height: " + height.ToString("F0") + " m";
    }
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener(delegate { SetHeight(); });
        SetHeight();
    }
}
