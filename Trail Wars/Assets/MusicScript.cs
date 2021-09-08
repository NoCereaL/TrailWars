using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    private AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(music);
    }

    public void PlayMusic()
    {
        music.Play();
    }

    public void StopMusic()
    {
        music.Stop();
    }
}
