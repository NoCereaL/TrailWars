using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPValueText : MonoBehaviour
{
    public Text xpValue;
    public Text levelValue;
    public Slider slider;
    public Text totalXPValue;

    public void Update()
    {
        xpValue.text = PlayerPrefs.GetInt("XP") + "XP";
        slider.value = PlayerPrefs.GetInt("XP");
        levelValue.text = "LVL: " + PlayerPrefs.GetInt("LevelXP");
        totalXPValue.text = "Total XP: " + PlayerPrefs.GetInt("TotalXP") + "XP";
        if(PlayerPrefs.GetInt("XP") >= 100)
        {
            PlayerPrefs.SetInt("XP", PlayerPrefs.GetInt("XP") - 100);
            PlayerPrefs.SetInt("LevelXP", PlayerPrefs.GetInt("LevelXP") + 1);
            levelValue.text = "LVL: " + PlayerPrefs.GetInt("LevelXP");
        }
    }
}
