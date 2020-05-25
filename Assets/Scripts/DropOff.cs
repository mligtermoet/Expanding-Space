using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropOff : MonoBehaviour
{
    [SerializeField] private bool playerInArea = false;
    [SerializeField] private GameObject sprite;
    [SerializeField] private Inventory inv;
    [SerializeField] private Text water;
    [SerializeField] private Text oxygen;
    [SerializeField] private Text energy;
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
        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true){
            inv.inv[0] = "Empty";
            inv.inv[1] = "Empty";
            inv.inv[2] = "Empty";
            water.text = "Empty";
            oxygen.text = "Empty";
            energy.text = "Empty";
        }
    }
}
