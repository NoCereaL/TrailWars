using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipColor : MonoBehaviour
{
    private Image itemImage;
    public Color32 color;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        itemImage = this.gameObject.GetComponent<Image>();
        audio = this.gameObject.GetComponent<AudioSource>();
        Vibration.Init();
    }

    // Update is called once per frame
    void Update()
    {
        color = itemImage.color;
    }

    public void Equip()
    {
        PlayerPrefs.SetFloat("R", color.r);
        PlayerPrefs.SetFloat("G", color.g);
        PlayerPrefs.SetFloat("B", color.b);
        audio.Play();
        Vibration.VibratePop();
    }
}
