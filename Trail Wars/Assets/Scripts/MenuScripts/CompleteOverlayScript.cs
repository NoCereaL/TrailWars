using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteOverlayScript : MonoBehaviour
{
    public GameObject completeOverlay;
    private string currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        CheckCompletion();
    }

    public void CheckCompletion()
    {
        if (PlayerPrefs.GetInt("is" + currentLevel + "complete") == 1)
        {
            completeOverlay.SetActive(true);
        }
        else
        {
            completeOverlay.SetActive(false);
        }
    }
}
