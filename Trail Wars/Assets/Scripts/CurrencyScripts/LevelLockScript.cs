using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLockScript : MonoBehaviour
{
    public CheckShape levelLock;
    public Text levelLockText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        levelLockText.text = "LVL: " + levelLock.levelLock;
        
    }
}
