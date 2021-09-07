using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightsSlider : MonoBehaviour
{
    private Slider slider;
    public float brightness;
    public Text value;
    public Image preview;
    // Start is called before the first frame update
    void Start()
    {
        slider = this.gameObject.GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("Brightness");
    }

    // Update is called once per frame
    void Update()
    {
        brightness = slider.value;
        value.text = slider.value +"";
        preview.color = new Color(slider.value, slider.value,slider.value);
        PlayerPrefs.SetFloat("Brightness", slider.value);
    }
}
