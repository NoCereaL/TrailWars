using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderTick : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = this.gameObject.GetComponent<AudioSource>();
    }

    public void PlayTick()
    {
        audio.Play();
    }
}
