using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoLevel()
    {
        SceneManager.LoadScene("Level");
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("Level");
    }
}
