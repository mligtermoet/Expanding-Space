using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EnergyStation : MonoBehaviour
{
    
    [SerializeField] private GameObject sprite;
    [SerializeField] private bool playerInArea = false;
    public bool isRunning = false;
    public bool isReady = false;

    [SerializeField] private Text text;
    
    [SerializeField] private GameObject animation;

    [SerializeField] private Inventory inv;
    [SerializeField] private GameObject ready;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        sprite.active = true;
        playerInArea = true;
    }

    void OnTriggerExit(Collider other)
    {
        sprite.active = false;
        playerInArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true && isRunning == false && isReady == false){
            isRunning = true;
            animation.active = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true && isRunning == false && isReady == true){
            if (inv.inv[2] == "Empty"){
                inv.inv[2] = "Energy";
                text.text = "Energy";
                isReady = false;
            }
            
        }
        if (isReady == true){
            ready.active = true;
        } else {
            ready.active = false;
        }
    }
}
