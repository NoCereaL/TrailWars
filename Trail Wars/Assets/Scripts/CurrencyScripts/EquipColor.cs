using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipColor : MonoBehaviour
{
    private Image itemImage;
    public float red;
    // Start is called before the first frame update
    void Start()
    {
        itemImage = this.gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        red = itemImage.color.r;
    }

    public void Equip()
    {
        PlayerPrefs.SetFloat("R", (byte)itemImage.color.r);
        PlayerPrefs.SetFloat("G", (byte)itemImage.color.g);
        PlayerPrefs.SetFloat("B", (byte)itemImage.color.b);
    }
}
