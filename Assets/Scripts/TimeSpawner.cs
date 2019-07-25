using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpawner : MonoBehaviour
{
	public GameObject spawn;
	public int stopSpawning=0;
	public float spawnTime;
	public float spawnDelay;
	private int sayac=0;
    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating("SpawnObject",spawnTime,spawnDelay);
    }

    // Update is called once per frame
    public void SpawnObject()
    {
     Instantiate(spawn,transform.position,transform.rotation);
	 if(sayac == stopSpawning){
		 CancelInvoke("SpawnObject");
    }
	sayac++;
}
}
