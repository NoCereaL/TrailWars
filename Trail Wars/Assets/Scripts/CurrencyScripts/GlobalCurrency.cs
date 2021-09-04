using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCurrency : MonoBehaviour
{
    public static int diamond;
    public int appendDiamond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddCurrency(int diamond)
    {
        int appendDiamond = PlayerPrefs.GetInt("Diamond") + diamond;
        PlayerPrefs.SetInt("Diamond", appendDiamond);
    }
}
