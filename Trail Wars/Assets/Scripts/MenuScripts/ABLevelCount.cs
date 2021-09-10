using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ABLevelCount : MonoBehaviour
{
    private GridLayoutGroup group;
    // Start is called before the first frame update
    void Start()
    {
        group = this.gameObject.GetComponent<GridLayoutGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("ABLevelCount", group.transform.childCount);
    }
}
