using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStatus : MonoBehaviour
{
    public string levelName;
    public int status;
    private GameObject button;
    public GameObject lockIcon;
    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
        levelName = button.name;
        status = PlayerPrefs.GetInt(levelName);        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeStatus();
    }

    public void ChangeStatus()
    {
        status = PlayerPrefs.GetInt(levelName);
        
        if (status == 1)
        {
            button.GetComponent<Button>().interactable = true;
            lockIcon.SetActive(false);
        }
    }
}
