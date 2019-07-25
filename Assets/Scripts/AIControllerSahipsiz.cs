using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControllerSahipsiz : MonoBehaviour
{
	GameObject[] hedefler;
	string[] secim={"kirmizi hedef","mavi hedef"};
	NavMeshAgent agent;
	
	public GameObject RedAgent;
	public GameObject BlueAgent;
	public GameObject Kullanici;
	
	public GameObject RedAgentLeaf;
	public GameObject BlueAgentLeaf;
	public GameObject KullaniciLeaf;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
		hedefler = GameObject.FindGameObjectsWithTag(secim[Random.Range(0,secim.Length)]);
        agent = this.GetComponent<NavMeshAgent>();
		agent.SetDestination(hedefler[Random.Range(0,hedefler.Length)].transform.position);
    }
	
	void Update()
	{
		if(agent.remainingDistance < 2)
		{
			hedefler = GameObject.FindGameObjectsWithTag(secim[Random.Range(0,secim.Length)]);
			agent.SetDestination(hedefler[Random.Range(0,hedefler.Length)].transform.position);
		}
	
	}
	void OnTriggerEnter(Collider co)
	{
		if(co.gameObject.CompareTag("Kirmizilar"))
		{
			GameObject redClone=Instantiate(RedAgentLeaf,gameObject.transform.position,gameObject.transform.rotation);
			redClone.GetComponent<AILeafController>().goal=RedAgent.gameObject;
			Destroy(this.gameObject);
			
		}
		else if(co.gameObject.CompareTag("Maviler"))
		{
			GameObject blueClone=Instantiate(BlueAgentLeaf,gameObject.transform.position,gameObject.transform.rotation);
			blueClone.GetComponent<AILeafController>().goal=BlueAgent.gameObject;
			Destroy(this.gameObject);
		
		}
		else if(co.gameObject.CompareTag("Kullanici"))
		{
			GameObject kullaniciClone=Instantiate(KullaniciLeaf,gameObject.transform.position,gameObject.transform.rotation);
			kullaniciClone.GetComponent<AILeafController>().goal=Kullanici.gameObject;
			Destroy(this.gameObject);
			
		}
	}
}
