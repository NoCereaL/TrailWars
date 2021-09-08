using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticVibrations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vibration.Init();
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
