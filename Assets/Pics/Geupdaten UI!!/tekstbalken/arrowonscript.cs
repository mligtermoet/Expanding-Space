using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowonscript : MonoBehaviour
{
    public GameObject activetext;
    
    public GameObject nexttext;
    public SpriteRenderer activearrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.activearrow = GetComponent<SpriteRenderer>();
        if(activetext.activeSelf == true)
        {
            this.activearrow.enabled = true;
        }

        if(nexttext.activeSelf == true)
        {
            this.activearrow.enabled = false;
        }
    }
}
