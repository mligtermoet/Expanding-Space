using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verdwijn : MonoBehaviour
{
    private float timer;
    [SerializeField] private GameObject water;
    [SerializeField] private GameObject energy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 3){
            
            water.SetActive(false);
            energy.SetActive(false);
            this.gameObject.SetActive(false);
            
            timer = 0;
            
        }
    }

    
}
