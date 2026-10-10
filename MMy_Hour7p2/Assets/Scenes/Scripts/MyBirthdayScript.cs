using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthdayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Date = 1;
        if (Date != 31)
        {
            for (int i = Date; i <= 31; i++)
            
                Debug.Log(i);

        }
    
   else if (Date == 26){

    Debug.Log(Date);
   }

    
    }

    // Update is called once per frame
    void Update()
    {

     
        


    }
}
