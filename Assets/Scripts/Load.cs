using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public GameObject activewinscreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activewinscreen.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
}
