using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardCanvasScript : MonoBehaviour
{
    public GameObject player;
    private NextLevel nextLevel;
    private CSNextLevel csNextLevel;
    private DBNextLevel dbNextLevel;
    public Text diamond;
    public Text xp;
    // Start is called before the first frame update
    void Start()
    {
        if(player.GetComponent<NextLevel>() != null)
        {
            nextLevel = player.GetComponent<NextLevel>();
        }
        if (player.GetComponent<CSNextLevel>() != null)
        {
            csNextLevel = player.GetComponent<CSNextLevel>();
        }
        if (player.GetComponent<DBNextLevel>() != null)
        {
            dbNextLevel = player.GetComponent<DBNextLevel>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<NextLevel>() != null)
        {
            if (PlayerPrefs.GetInt(nextLevel.level) == 0)
            {
                diamond.text = "10";
                xp.text = "+25XP";
            }
            else
            {
                diamond.text = "5";
                xp.text = "+10XP";
            }
        }

        if (player.GetComponent<CSNextLevel>() != null)
        {
            if (PlayerPrefs.GetInt(csNextLevel.level) == 0)
            {
                diamond.text = "10";
                xp.text = "+25XP";
            }
            else
            {
                diamond.text = "5";
                xp.text = "+10XP";
            }
        }

        if (player.GetComponent<DBNextLevel>() != null)
        {
            if (PlayerPrefs.GetInt(dbNextLevel.level) == 0)
            {
                diamond.text = "10";
                xp.text = "+25XP";
            }
            else
            {
                diamond.text = "5";
                xp.text = "+10XP";
            }
        }
    }
}
