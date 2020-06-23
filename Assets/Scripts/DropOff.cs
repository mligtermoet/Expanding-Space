using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropOff : MonoBehaviour
{
    [SerializeField] private bool playerInArea = false;
    [SerializeField] private GameObject sprite;
    [SerializeField] private Inventory inv;
    [SerializeField] private GameObject mensenAnim;
    [SerializeField] private RandomQuest randomQuest;
    public bool questactive = false;
    

    [SerializeField] private Money money;
    [SerializeField] private GameObject vraagbalk;
    public string benoodigd;
    [SerializeField] private GameObject coinAnimation;
    [SerializeField] private GameObject Vinkje;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(questactive){
            sprite.active = true;
            playerInArea = true;
            vraagbalk.SetActive(true);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        sprite.active = false;
        playerInArea = false;
        vraagbalk.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true && inv.inv == benoodigd && questactive){
            inv.inv = "Empty";
            coinAnimation.SetActive(true);
            Vinkje.SetActive(true);
            
            money.moneyAmount += 100;
            questactive = false;
            mensenAnim.SetActive(false);
            randomQuest.number = Random.Range(0,2);
            

        }
        if (Input.GetKeyDown(KeyCode.E) && playerInArea == true && inv.inv != benoodigd){
            inv.inv = "Empty";
            
        }
    }
}
