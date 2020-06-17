using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public string inv = "Empty";
    [SerializeField] private GameObject Water;
    [SerializeField] private GameObject Energy;
    [SerializeField] private GameObject Food;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inv == "Water"){
            Water.active = true;
        } else if (inv == "Energy"){
            Energy.active = true;
        } else if (inv == "Food"){
            Food.active = true;
        } else {
            Water.active = false;
            Energy.active = false;
            Food.active = false;
        }
    }
}
