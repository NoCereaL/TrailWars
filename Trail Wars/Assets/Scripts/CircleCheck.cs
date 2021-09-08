using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCheck : MonoBehaviour
{
    public GameObject circle;
    private SpriteRenderer player;
    private SpriteRenderer circleRenderer;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject.GetComponent<SpriteRenderer>();
        circleRenderer = circle.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.sprite.name == "Circle")
        {
            circle.SetActive(true);
            circleRenderer.enabled = true;
        }
        else
        {
            circle.SetActive(false);
            circleRenderer.enabled = false;
        }
    }
}
