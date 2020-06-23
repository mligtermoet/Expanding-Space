using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textscript : MonoBehaviour
{
    public GameObject currenttext;
    public GameObject nexttext;
    public AudioSource Astro;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(currenttext.activeSelf == true)
            {
                currenttext.SetActive(false);
                nexttext.SetActive(true);
                Astro.Play();
            }
        }
    }
}
