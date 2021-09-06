using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipShape : MonoBehaviour
{
    public GameObject itemName;
    // Start is called before the first frame update
    void Start()
    {
        itemName = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Equip()
    {
        PlayerPrefs.SetInt("PlayerShape", int.Parse(itemName.name));
    }
}
