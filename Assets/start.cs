using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject main;
    
    // Start is called before the first frame update
    void Start()
    {
        main.GetComponent<Base>().enabled = false;
        Invoke("being", 2);

    }


    // Update is called once per frame
    void being()
    {
        main.GetComponent<Base>().enabled = true;
        Destroy(gameObject);
    }
}
