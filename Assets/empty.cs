using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class empty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("being", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
        Application.Quit();
        }
    }
    void being()
    {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

