using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckShape : MonoBehaviour
{
    public GameObject itemName;
    public GameObject owned;
    public GameObject equipped;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(itemName.name) == PlayerPrefs.GetInt("PlayerShape"))
        {
            owned.SetActive(false);
            equipped.SetActive(true);
        }
    }
}
