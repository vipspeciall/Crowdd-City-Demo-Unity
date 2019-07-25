using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControllerKullanici : MonoBehaviour
{
	public GameObject prefab;
	public bool triggerDeath=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter(Collider co)
    {
        Debug.Log("gameObject:");
        GameObject UserClone=Instantiate(prefab,gameObject.transform.position,gameObject.transform.rotation);
		UserClone.GetComponent<AILeafController>().goal=this.gameObject;
		Destroy(co.gameObject);
		triggerDeath=true;
		  
    }
}
