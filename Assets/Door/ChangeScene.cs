using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    FadeInOut fade;
    // Start is called before the first frame update
    void Start()
    {
        fade = FindObjectOfType<FadeInOut>();
    }
    
    public IEnumerator LChangeScene()
    {
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Ute");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(LChangeScene());
        }
    }
}
