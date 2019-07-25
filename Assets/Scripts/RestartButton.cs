using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restarting()
	{
		SceneManager.LoadScene("level1");
	}
	public void Quitting()
	{
		Application.Quit();
	}
}
