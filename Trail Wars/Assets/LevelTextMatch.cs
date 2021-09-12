using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTextMatch : MonoBehaviour
{
    private Text levelText;
    public GameObject level;
    // Start is called before the first frame update
    void Start()
    {
        levelText = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = level.name;
    }
}
