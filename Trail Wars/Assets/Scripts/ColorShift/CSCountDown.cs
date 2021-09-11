using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSCountDown : MonoBehaviour
{
    public Text countText;
    public Rigidbody2D rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator.enabled = true;
        rb = GameObject.Find("CSPlayer").GetComponent<Rigidbody2D>();
        StartCoroutine(StartCount());
    }

    IEnumerator StartCount()
    {
        yield return new WaitForSeconds((float)0.5);
        animator.enabled = true;
        countText.text = "3";
        yield return new WaitForSeconds((float)0.5);
        countText.text = "2";
        yield return new WaitForSeconds((float)0.5);
        countText.text = "1";
        yield return new WaitForSeconds((float)0.5);
        countText.text = "";
        animator.enabled = false;
        if (PauseMenuScript.pauseOpen == false)
            rb.isKinematic = false;
    }
}
