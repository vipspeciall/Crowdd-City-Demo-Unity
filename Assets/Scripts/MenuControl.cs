﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    public void oyunaBasla()
    {
        SceneManager.LoadScene("Acilisanimasyon");
    }
	
	public void cikis()
	{
		Application.Quit();
	}
	
}
