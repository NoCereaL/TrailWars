using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationToggle : MonoBehaviour
{
    public GameObject vibedButton;
    public GameObject vibedOffButton;
    public void Update()
    {
        if(PlayerPrefs.GetInt("Vibration") == 1)
        {
            AudioListener.volume = 0;
            vibedButton.SetActive(false);
            vibedOffButton.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("Vibration") == 0)
        {
            AudioListener.volume = 1;
            vibedButton.SetActive(true);
            vibedOffButton.SetActive(false);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public void VibrationOff()
    {
        PlayerPrefs.SetInt("Vibration", 1);
        AudioListener.volume = 0;
        vibedButton.SetActive(false);
        vibedOffButton.SetActive(true);
    }

    public void VibrationOn()
    {
        PlayerPrefs.SetInt("Vibration", 0);
        AudioListener.volume = 1f;
        vibedButton.SetActive(true);
        vibedOffButton.SetActive(false);
    }
}
