using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleRings : MonoBehaviour
{public GameObject RingPrefab;
 public int NumberOfRings; 
 public float AnimationSpeed; 
 private float Timer; 
 private int CreateRings; //spond
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        Timer += Time.deltaTime; 
        if(Timer >= AnimationSpeed){
            Instantiate(RingPrefab, transform);
            Timer = 0;
            CreateRings ++; 
            if(CreateRings == NumberOfRings) 
            enabled = false;
            
        }

        
    }

    private void OnEnable() 
    {
        
    }
}
