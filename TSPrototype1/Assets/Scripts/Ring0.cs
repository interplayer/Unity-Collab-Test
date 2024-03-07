using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring0 : MonoBehaviour
{
    public GameObject RingPrefab; //named "RingPrefab" to access 
    public int NumberOfRings;//
    public float AnimationSpeed;//how fast the ring spon
    private float Timer;//keep tracking the time  
    private int CreateRings; //define an intger that is repersenting numnbers of rings I have created 


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;                //+= timer increace than equal  
        if(Timer >= AnimationSpeed)             //grater than equal to Animation Speed 
        {
            Instantiate(RingPrefab, transform); //추상적인것을 예를들어 설명하다 
            Timer = 0;
            CreateRings ++;                     //++ means increace 
            if (CreateRings == NumberOfRings)   //don't need {} when if statment is ONE line
                enabled = false;

        }
    }

    private void OnEnable()
    {
        
    }
}
