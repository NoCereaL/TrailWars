using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItemScript : MonoBehaviour
{
    private string itemName;
    public int itemAmount;
    public Text amountText;
    // Start is called before the first frame update
    void Start()
    {
        itemName = this.gameObject.name;
    }

    void Update()
    {
        itemAmount = int.Parse(amountText.text);
    }

    public void BuyItem() {
        if(PlayerPrefs.GetInt(itemName) == 0)
        {
            PlayerPrefs.SetInt(itemName, 1);
            PlayerPrefs.SetInt("Diamond", PlayerPrefs.GetInt("Diamond") - itemAmount);      //Buy The Item and take away from player cash
        }
    }
}
