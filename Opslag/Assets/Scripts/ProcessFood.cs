using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessFood : MonoBehaviour
{
    [SerializeField] private GameObject self;
    [SerializeField] private FoodStation script;
    // Start is called before the first frame update
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 3.8){
            timer = 0;
            
            script.isReady = true;
            script.isRunning = false;
            self.active = false;
        }

        
        

        
    }
}
