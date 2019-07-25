using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{ 
private float speed = 10.0F;

void Start()
    {
       
    }
    
void Update()
    {
    float translation = Input.GetAxis("Vertical") * speed;
	float straffe = Input.GetAxis("Horizontal") * speed;
	translation *= Time.deltaTime;
	straffe *= Time.deltaTime;
	
	transform.Translate(straffe,0,translation);
	
    }
    
}