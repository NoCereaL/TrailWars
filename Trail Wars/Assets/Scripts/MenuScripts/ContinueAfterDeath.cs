using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueAfterDeath : MonoBehaviour
{
    private GameObject continueCanvas;
    public GameObject cam;
    public GameObject cameraHolder;
    public Transform player;
    public Transform particalController;
    public Rigidbody2D rb;
    public AudioSource audio;

    //Count Down
    public Animator animator;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        continueCanvas = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ContinueFromDeath()
    {
        continueCanvas.SetActive(false);
        player.position = new Vector3(particalController.position.x, particalController.position.y + 2.5f, particalController.position.z);
        cam.transform.SetParent(cameraHolder.transform);
        //rb.isKinematic = false;
        if (player.GetComponent<PlayerMovement>() != null)
        {
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        CheckContinues.numOfContinuesUsed = 1;
        audio.Play();
    }

    public void StartCountDown()
    {
        StartCoroutine(StartCount());
    }

    public IEnumerator StartCount()
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