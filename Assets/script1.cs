using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public string[] murid;

    public float waktu;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waktu += Time.deltaTime;

        if(waktu > 1){
            waktu = 0;
            Debug.Log(murid[index]);
            
            // Variasi 1
            // index++;
            // if (index >= murid.Length) index = 0;

            // Variasi 2
            index = (index+1) % murid.Length;
        }
        // waktu += Time.deltaTime;

        // if(waktu > 1f){

        //     Debug.Log(index);
        //     if(index < murid.Length)

        //     Debug.Log(murid[index]);
        //     index++;

        //     waktu = 0f;
        // }
    }
}
