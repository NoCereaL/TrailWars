using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentAmount : MonoBehaviour
{
    private Text amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        amount.text = PlayerPrefs.GetInt("Diamond") +"";
    }
}
