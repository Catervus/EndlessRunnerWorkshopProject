using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionHandler : MonoBehaviour
{
	private int score;

	private void OnCollisionEnter2D(Collision2D _col)
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	private void OnTriggerEnter2D(Collider2D _other)
	{
		score++;
		Debug.Log("Score: " + score);
	}
}
