using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalXP : MonoBehaviour
{
    public static int XP;
    public static int totalXP;
    public static int levelXP;

    public static void AddXP(int xp)
    {
        int appendXP = PlayerPrefs.GetInt("XP") + xp;
        PlayerPrefs.SetInt("XP", appendXP);
    }

    public static void AddToTotalXP(int xp)
    {
        int appendXP = PlayerPrefs.GetInt("TotalXP") + xp;
        PlayerPrefs.SetInt("TotalXP", appendXP);
    }

    public static void AddLevelXP(int xp)
    {
        int appendXP = PlayerPrefs.GetInt("LevelXP") + xp;
        PlayerPrefs.SetInt("LevelXP", appendXP);
    }
}
