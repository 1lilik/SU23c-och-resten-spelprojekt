using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogborder : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    public string[] Sentenses;
    int SentenceNumber = 0;
    public GameObject UIBox;
    bool isInArea = false;
    public GameObject responseBox;


    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isInArea = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isInArea = false;
    }


    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Space) && isInArea == true && responseBox.active == false)
        {
            UIBox.SetActive(true);
            textbox.text = Sentenses[SentenceNumber];
            SentenceNumber++;

            if (SentenceNumber == 4)
            {
                responseBox.SetActive(true);
            }
            if (SentenceNumber == 9)
            {
                UIBox.SetActive(false);

                SceneManager.LoadScene("good end");
            }
        }

    }
    public void NoButtonPressed()
    {
        responseBox.SetActive(false);
        UIBox.SetActive(true);
        textbox.text = Sentenses[SentenceNumber];
        SentenceNumber++;

        if (SentenceNumber == 9)
        {
            UIBox.SetActive(false);

            SceneManager.LoadScene("good end");
        }
    }
}
