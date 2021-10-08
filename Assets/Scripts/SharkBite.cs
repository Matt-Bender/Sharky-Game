using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkBite : MonoBehaviour
{
    private UIManager uiScript;
    // Start is called before the first frame update
    void Start()
    {
        uiScript = GameObject.Find("GameManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Checks if fish objects enter the box for shark biting
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GoodFish"))
        {
            Destroy(collision.gameObject);
            uiScript.IncreaseScore();
        }
        if (collision.gameObject.CompareTag("BadFish"))
        {
            Destroy(collision.gameObject);
            uiScript.DecreaseLives();
        }
    }
}
