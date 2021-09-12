using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    public GameObject audioButton;
    public GameObject muteButton;
    public void Update()
    {
        if(PlayerPrefs.GetInt("Mute") == 1)
        {
            AudioListener.volume = 0;
            audioButton.SetActive(false);
            muteButton.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("Mute") == 0)
        {
            AudioListener.volume = 1;
            audioButton.SetActive(true);
            muteButton.SetActive(false);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public void MuteAllAudio()
    {
        PlayerPrefs.SetInt("Mute", 1);
        AudioListener.volume = 0;
        audioButton.SetActive(false);
        muteButton.SetActive(true);
    }

    public void UnMuteAllAudio()
    {
        PlayerPrefs.SetInt("Mute", 0);
        AudioListener.volume = 1f;
        audioButton.SetActive(true);
        muteButton.SetActive(false);
    }
}
