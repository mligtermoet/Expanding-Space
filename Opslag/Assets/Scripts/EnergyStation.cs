using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EnergyStation : MonoBehaviour
{
    
    [SerializeField] private GameObject sprite;
    [SerializeField] private GameObject isReadytext;
    [SerializeField] private bool playerInArea = false;
    public bool isRunning = false;
    public bool isReady = false;

    
    
    [SerializeField] private GameObject animation;

    [SerializeField] private Inventory inv;
    [SerializeField] private GameObject ready;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(isReady == false && isRunning == false){
            sprite.active = true;
        }
        if(isReady== true && isRunning == false){
            isReadytext.active = true;
        }        
        
        playerInArea = true;
    }

    void OnTriggerExit(Collider other)
    {
        sprite.active = false;
        isReadytext.active = false;
        playerInArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true && isRunning == false && isReady == false){
            isRunning = true;
            animation.active = true;
            sprite.active = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true && isRunning == false && isReady == true){
            if (inv.inv == "Empty"){
                inv.inv = "Energy";
                isReadytext.active = false;
                sprite.active = true;
                isReady = false;
            }
            
        }
        if (isReady == true){
            ready.active = true;
            if(playerInArea == true){
                isReadytext.active = true;
            }
            
        } else {
            ready.active = false;
        }
    }
}
