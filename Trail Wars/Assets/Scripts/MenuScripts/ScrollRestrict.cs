using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRestrict : MonoBehaviour
{
    private RectTransform rectTransform;
    private Vector3 currentPos;
    public ScrollRect scrollRect;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = this.gameObject.GetComponent<RectTransform>();
        currentPos = new Vector3(rectTransform.position.x, rectTransform.position.y, rectTransform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        RestrictMaxScroll();   
    }

    public void RestrictMaxScroll()
    {
        if (rectTransform.position.y <= currentPos.y)
        {
            scrollRect.movementType = ScrollRect.MovementType.Elastic;
        }
        else
        {
            scrollRect.movementType = ScrollRect.MovementType.Unrestricted;
        }
    }
}
