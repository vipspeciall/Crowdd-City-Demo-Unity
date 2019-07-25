using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class AILeafControllerKirmizi : MonoBehaviour
{
	public GameObject goal;
	
	public GameObject redpopulation;
	public GameObject bluepopulation;
	public GameObject userpopulation;
	
	public GameObject RedAgentLeaf;
	public GameObject BlueAgentLeaf;
	public GameObject KullaniciLeaf;
	
	public GameObject RedAgent;
	public GameObject BlueAgent;
	public GameObject Kullanici;
	
	NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
		agent.SetDestination(goal.transform.position);
    }
	void Update()
	{
		agent = this.GetComponent<NavMeshAgent>();
		agent.SetDestination(goal.transform.position);
	}
	
	void OnTriggerEnter(Collider co)
	{
		if(co.gameObject.CompareTag("Kirmizilar"))
		{
			
		}
		else if(co.gameObject.CompareTag("Maviler"))
		{
			
			if( int.Parse(redpopulation.GetComponent<TextMeshPro>().text.ToString()) > int.Parse(bluepopulation.GetComponent<TextMeshPro>().text.ToString()) )
			{
				
				GameObject redClone=Instantiate(RedAgentLeaf,gameObject.transform.position,gameObject.transform.rotation);
				goal=RedAgent.gameObject;
				Destroy(this.gameObject);
				
			}
			
			
		}
		
		else if(co.gameObject.CompareTag("Kullanici"))
		{
			if( int.Parse(redpopulation.GetComponent<TextMeshPro>().text.ToString()) > int.Parse(userpopulation.GetComponent<TextMeshPro>().text.ToString()) )
			{
				
				GameObject redClone=Instantiate(RedAgentLeaf,gameObject.transform.position,gameObject.transform.rotation);
				goal=RedAgent.gameObject;
				Destroy(co.gameObject);
				
			}
			else if(int.Parse(redpopulation.GetComponent<TextMeshPro>().text.ToString()) < int.Parse(userpopulation.GetComponent<TextMeshPro>().text.ToString()))
			{
				GameObject userClone=Instantiate(KullaniciLeaf,gameObject.transform.position,gameObject.transform.rotation);
				goal=Kullanici.gameObject;
				Destroy(this.gameObject);
				
			}
			
		}
	}
	
}
