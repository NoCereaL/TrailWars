using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    private GameObject button;
    private AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
        buttonClick = this.gameObject.GetComponent<AudioSource>();
        Vibration.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        Vibration.VibratePop();
        SceneManager.LoadScene(button.name);
        buttonClick.Play();
    }
}
