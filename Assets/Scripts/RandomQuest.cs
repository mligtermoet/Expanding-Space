using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomQuest : MonoBehaviour
{
    [SerializeField]private float timer;
    [SerializeField]private DropOff dropoff;
    [SerializeField]public int number;
    [SerializeField]private float cooldown = 2.0f;
    [SerializeField] private GameObject mensenAnim;


    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(0,2);
    }

    // Update is called once per frame
    void Update()
    {
        if(!dropoff.questactive){
            timer += Time.deltaTime;
        }

        if(number == 0){
                dropoff.benoodigd = "Water";
                
            }else{
                dropoff.benoodigd = "Energy";
            }
        

        if (timer >=  cooldown && !dropoff.questactive){
            timer = 0;
            dropoff.questactive = true;
            cooldown = Random.Range(2.0f,12.0f);
            
            mensenAnim.SetActive(true);

            
            
            
        }
    }
}
