using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
	GameObject[] redagents;
	GameObject[] blueagents;
	GameObject[] kullanici;
	
	public GameObject uitext1;
	public GameObject uitext2;
	public GameObject uitext3;
	public GameObject camera;
	
	public GameObject anamavi;
	public GameObject anakullanici;
	public GameObject anakirmizi;
	public GameObject scoretext;
	
	Vector3 playerTransform;
	Vector3 cameraTransform;
	RectTransform defaultRec;
	
	public Camera[] cameras;
	public GameObject scoreScreen;
	bool triggerUserDeath=false;
    // Start is called before the first frame update
    void Start()
    {
		playerTransform = anakullanici.transform.position;
		cameraTransform = camera.transform.position;
    }
	
	void Update(){
				
		redagents = GameObject.FindGameObjectsWithTag("Kirmizilar");
        blueagents = GameObject.FindGameObjectsWithTag("Maviler");
		kullanici = GameObject.FindGameObjectsWithTag("Kullanici");
		
		
		
		if(anakullanici)
		{
			camera.transform.position=new Vector3(anakullanici.transform.position.x,cameraTransform.y+10,anakullanici.transform.position.z-40);	
			uitext3.GetComponent<TextMeshPro>().text = kullanici.Length.ToString();
			
		}
		
		else if(!anakullanici){
			GameOver();
						
		
		}
		
		
		if(anakirmizi)
		{
			uitext1.GetComponent<TextMeshPro>().text = redagents.Length.ToString();
		}
		
		else if(!anakirmizi)
		{
			if(!anamavi)
				{
					scoretext.GetComponent<Text>().text=kullanici.Length.ToString();
					camera.SetActive(false);
					scoreScreen.SetActive(true);
				}
			
		}
		
		
		if(anamavi)
		{
			uitext2.GetComponent<TextMeshPro>().text = blueagents.Length.ToString();
		}
		
		else if(!anamavi){
			if(!anakirmizi)
				{
					scoretext.GetComponent<Text>().text=kullanici.Length.ToString();
					camera.SetActive(false);
					scoreScreen.SetActive(true);
				}
		}
		
		// if(mavi.GetComponent<AIControllerMavi>().triggerDeath)
		// {
			// UnityEngine.SceneManagement.SceneManager.LoadScene("level1");
		// }
		
	}
	void GameOver()
	{
		
		scoretext.GetComponent<Text>().text="0";
		camera.SetActive(false);
		scoreScreen.SetActive(true);
	}
	
    // Update is called once per frame
}
