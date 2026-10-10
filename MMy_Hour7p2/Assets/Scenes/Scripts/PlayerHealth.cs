using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     float health = 1004f;
     float poisonDamage = 125.5f;   

     Debug.Log(health);

     float totalHealth = health - poisonDamage;

     Debug.Log(totalHealth);


    }

    // Update is called once per frame
    void Update()
    {

   float health = 1004f;
     float poisonDamage = 125.5f;   

     Debug.Log(health);
     Debug.Log(poisonDamage);

     float totalHealth = health - poisonDamage;

     Debug.Log(totalHealth);

     totalHealth = totalHealth - 125.5f; 
     Debug.Log(totalHealth);
     
    totalHealth = totalHealth - 125.5f; 
     Debug.Log(totalHealth);

     totalHealth = totalHealth - 125.5f; 
     Debug.Log(totalHealth);

     totalHealth = totalHealth - 125.5f; 
     Debug.Log(totalHealth);

     totalHealth = totalHealth - 125.5f; 
     Debug.Log(totalHealth);
     
    totalHealth = totalHealth - 125.5f; 
     Debug.Log(totalHealth);

     totalHealth = totalHealth - 125.5f; 
     Debug.Log(totalHealth);

     Debug.Log("Player has been unalived!");

    }

}
