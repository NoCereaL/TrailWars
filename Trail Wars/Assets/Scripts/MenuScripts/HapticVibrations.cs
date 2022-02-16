using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticVibrations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Set Defualt Vibration Status for first time launch
        if (PlayerPrefs.HasKey("Vibration") == false)
        {
            PlayerPrefs.SetInt("Vibration", 1);
        }

        if (PlayerPrefs.GetInt("Vibration") == 1)
        {
            Vibration.Init();
        }
    }

    public void Peek()
    {
        Vibration.VibratePeek();
    }

    public void Pop()
    {
        Vibration.VibratePop();
    }
}
