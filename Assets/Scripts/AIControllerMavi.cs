using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class AIControllerMavi : MonoBehaviour
{
	GameObject[] hedefler;
	NavMeshAgent agent;
	public bool triggerDeath=false;
	
	public GameObject redpopulation;
	public GameObject bluepopulation;
	public GameObject userpopulation;
	
	public GameObject RedAgent;
	public GameObject BlueAgent;
	public GameObject Kullanici;
	
	public GameObject RedAgentLeaf;
	public GameObject BlueAgentLeaf;
	public GameObject KullaniciLeaf;
    // Start is called before the first frame update
    void Start()
    {
		hedefler = GameObject.FindGameObjectsWithTag("mavi hedef");
        agent = this.GetComponent<NavMeshAgent>();
		agent.SetDestination(hedefler[Random.Range(0,hedefler.Length)].transform.position);
    }
	
	void Update()
	{
		
		if(agent.remainingDistance < 2)
		{
			agent.SetDestination(hedefler[Random.Range(0,hedefler.Length)].transform.position);
		}
	}
	
	void OnTriggerEnter(Collider co)
    {
        Debug.Log("gameObject:");
		if(co.gameObject.CompareTag("Kirmizilar"))
		{	
			if( int.Parse(bluepopulation.GetComponent<TextMeshPro>().text.ToString()) > int.Parse(redpopulation.GetComponent<TextMeshPro>().text.ToString()) )
			{
				
				GameObject maviClone=Instantiate(BlueAgentLeaf,gameObject.transform.position,gameObject.transform.rotation);
				maviClone.GetComponent<AILeafController>().goal=BlueAgent.gameObject;
				Destroy(co.gameObject);
				
				
			}
		
			
			
			// else if(int.Parse(bluepopulation.gameObject.GetComponent<Text>()) == int.Parse(redpopulation.GetComponent<Text>()))
			// {
				// continue;
			// }
		}
		
		else if(co.gameObject.CompareTag("Kullanici"))
		{
			if( int.Parse(bluepopulation.GetComponent<TextMeshPro>().text.ToString()) > int.Parse(userpopulation.GetComponent<TextMeshPro>().text.ToString()) )
			{
				
				GameObject maviClone=Instantiate(BlueAgentLeaf,gameObject.transform.position,gameObject.transform.rotation);
				maviClone.GetComponent<AILeafController>().goal=BlueAgent.gameObject;
				Destroy(co.gameObject);
				
				
			}
			else if(int.Parse(bluepopulation.GetComponent<TextMeshPro>().text.ToString()) < int.Parse(userpopulation.GetComponent<TextMeshPro>().text.ToString()))
			{
				GameObject userClone=Instantiate(KullaniciLeaf,gameObject.transform.position,gameObject.transform.rotation);
				userClone.GetComponent<AILeafController>().goal=Kullanici.gameObject;
				Destroy(this.gameObject);
				
			}
			
		}
		
        
    }
	
	
	
}
