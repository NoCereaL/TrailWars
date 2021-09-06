using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckShape : MonoBehaviour
{
    //public GameObject itemName;

    public string itemName;
    public int itemAmount;
    public GameObject lockIcon;
    public Button button;
    public Text amountText;
    public GameObject DiamondImg;
    public GameObject Text;
    public GameObject equipped;
    public GameObject owned;

    public EquipColor item;
    public EquipShape itemShape;
    // Start is called before the first frame update
    void Start()
    {
        itemName = this.gameObject.name;
        button = this.gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        amountText.text = itemAmount + "";
        ToBuy();
    }

    public void ToBuy()
    {
        if (PlayerPrefs.GetInt("Diamond") >= itemAmount)       //if you have enough money you can buy
        {
            button.interactable = true;
        }
        if (PlayerPrefs.GetInt("Diamond") <= itemAmount && PlayerPrefs.GetInt(itemName) == 0)
        {
            button.interactable = false;
        }
        if (PlayerPrefs.GetInt(itemName) == 1)          //if you own then you can equip
        {
            button.interactable = true;
            lockIcon.SetActive(false);
            DiamondImg.SetActive(false);
            Text.SetActive(false);
            owned.SetActive(true);
        }
        if (int.Parse(itemName) == PlayerPrefs.GetInt("PlayerShape"))
        {
            owned.SetActive(false);
            equipped.SetActive(true);
        }
        else
        {
            equipped.SetActive(false);
        }
    }
}
