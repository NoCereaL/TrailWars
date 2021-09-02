using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject modeSelector;
    public GameObject abLevelSelect;
    public GameObject csLevelSelect;
    public GameObject dbLevelSelect;
    public GameObject credits;


    public void MainMenu()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
        modeSelector.SetActive(false);
        abLevelSelect.SetActive(false);
        csLevelSelect.SetActive(false);
        dbLevelSelect.SetActive(false);
    }

    public void Credits()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
        modeSelector.SetActive(false);
        abLevelSelect.SetActive(false);
        csLevelSelect.SetActive(false);
        dbLevelSelect.SetActive(false);
    }

    public void ModeSelector()
    {
        mainMenu.SetActive(false);
        credits.SetActive(false);
        modeSelector.SetActive(true);
        abLevelSelect.SetActive(false);
        csLevelSelect.SetActive(false);
        dbLevelSelect.SetActive(false);
    }

    public void ABLevels()
    {
        mainMenu.SetActive(false);
        credits.SetActive(false);
        modeSelector.SetActive(false);
        abLevelSelect.SetActive(true);
        csLevelSelect.SetActive(false);
        dbLevelSelect.SetActive(false);
    }

    public void DBLevles()
    {
        mainMenu.SetActive(false);
        credits.SetActive(false);
        modeSelector.SetActive(false);
        abLevelSelect.SetActive(false);
        csLevelSelect.SetActive(false);
        dbLevelSelect.SetActive(true);
    }

    public void CSLevels()
    {
        mainMenu.SetActive(false);
        credits.SetActive(false);
        modeSelector.SetActive(false);
        abLevelSelect.SetActive(false);
        csLevelSelect.SetActive(true);
        dbLevelSelect.SetActive(false);
    }
}
