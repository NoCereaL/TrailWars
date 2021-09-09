using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRotation : MonoBehaviour
{
    private ObstacleRotate obstacle;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = this.gameObject.GetComponent<ObstacleRotate>();
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseSpeed();
    }

    public void IncreaseSpeed()
    {
        if(ABEndlessScore.ABScore >= 30)
        {
            obstacle.speed = Random.Range(1, 3);
        }
        if (ABEndlessScore.ABScore >= 50)
        {
            obstacle.speed = Random.Range(3, 5);
        }
    }
}
