using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColor : MonoBehaviour
{
    public SpriteRenderer player;
    public SpriteRenderer obstacleColor;
    public BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerColor();
    }

    public void CheckPlayerColor()
    {
        if(player.color == obstacleColor.color)
        {
            boxCollider.isTrigger = true;
        }
        else
        {
            boxCollider.isTrigger = false;
        }
    }
}
