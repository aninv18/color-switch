﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	}
}