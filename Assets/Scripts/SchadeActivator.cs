using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchadeActivator : MonoBehaviour
{
    [SerializeField] private GameObject[] SchadeRuimtes;
    public float Countdown;
    private float timer;
    [SerializeField] public GameObject[] Generators;
    [SerializeField] private GameObject Schadetext;
    [SerializeField]public  bool isActive = false;


    void Start()
    {
        Countdown = Random.Range(20.0f,100.0f);
    }

    public void ActivateGenerators()
    {
        for (int i = 0; i < Generators.Length; i++)
        {
            Generators[i].SetActive(true);
        }
        Schadetext.SetActive(false);
    }

    public void DeactivateGenerators()
    {
        for (int i = 0; i < Generators.Length; i++)
        {
            Generators[i].SetActive(false);
        }
        Schadetext.SetActive(true);
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
