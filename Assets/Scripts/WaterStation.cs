using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class WaterStation : MonoBehaviour
{
    
    [SerializeField] private GameObject sprite;
    [SerializeField] private bool playerInArea = false;
    [SerializeField] private GameObject isReadytext;
    public bool isRunning = false;
    public bool isReady = false;

    
    
    [SerializeField] private GameObject animation;

    [SerializeField] private Inventory inv;
    [SerializeField] private GameObject ready;

    public AudioSource Water;


    
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
        playerInArea = false;
        isReadytext.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true && isRunning == false && isReady == false){
            isRunning = true;
            sprite.active = false;
            animation.active = true;
            Water.Play();
        }

        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true && isRunning == false && isReady == true){
            if (inv.inv == "Empty"){
                inv.inv = "Water";
                isReadytext.active = false;
                isReady = false;
            } 
            
        }
        if (isReady == true){
            ready.active = true;
            if(playerInArea == true){
                isReadytext.active = true;
                Water.Stop();
            }
        } else {
            ready.active = false;
        }
    }
}
