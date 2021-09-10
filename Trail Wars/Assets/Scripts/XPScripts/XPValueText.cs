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

    public Text ABLevels;
    public Text DBLevels;
    public Text CSLevels;

    public Text levelsComplete;
    public Text itemsOwned;

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

        ABLevels.text = "Levels: " + PlayerPrefs.GetInt("ABLevelsComplete") + " / " + PlayerPrefs.GetInt("ABLevelCount");
        DBLevels.text = "Levels: " + PlayerPrefs.GetInt("DBLevelsComplete") + " / " + PlayerPrefs.GetInt("DBLevelCount");
        CSLevels.text = "Levels: " + PlayerPrefs.GetInt("CSLevelsComplete") + " / " + PlayerPrefs.GetInt("CSLevelCount");

        int totalAmountOfLevels = PlayerPrefs.GetInt("ABLevelCount") + PlayerPrefs.GetInt("DBLevelCount") + PlayerPrefs.GetInt("CSLevelCount");
        PlayerPrefs.SetInt("TotalLevels", totalAmountOfLevels);

        levelsComplete.text = "Levels Complete: " + PlayerPrefs.GetInt("LevelsComplete") + " / " + PlayerPrefs.GetInt("TotalLevels");

        int totalItemsOwned = PlayerPrefs.GetInt("ShapesCount") + PlayerPrefs.GetInt("ColorsCount");
        PlayerPrefs.SetInt("TotalItemsOwned", totalItemsOwned);

        itemsOwned.text = "Items Owned: " + PlayerPrefs.GetInt("ItemsOwned") + " / " + PlayerPrefs.GetInt("TotalItemsOwned");
    }
}
