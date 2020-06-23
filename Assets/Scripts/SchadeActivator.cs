using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchadeActivator : MonoBehaviour
{
    [SerializeField] private GameObject[] SchadeRuimtes;
    public float Countdown;
    [SerializeField]private float timer;
    [SerializeField]public GameObject[] Generators;
    
    [SerializeField]public bool isActive = false;


    void Start()
    {
        // Countdown = Random.Range(10.0f,30.0f);
        isActive = true;
    }

    public void ActivateGenerators()
    {
        for (int i = 0; i < Generators.Length; i++)
        {
            Generators[i].SetActive(true);
        }
        
    }

    public void DeactivateGenerators()
    {
        for (int i = 0; i < Generators.Length; i++)
        {
            Generators[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(!isActive){
            timer += Time.deltaTime;
        }
        
        if (timer >= Countdown && !isActive){
            SchadeRuimtes[Random.Range(0,SchadeRuimtes.Length)].active = true;
            isActive = true;

            DeactivateGenerators();
            timer = 0;
        }
    }
}
