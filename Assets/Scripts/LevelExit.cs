using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {
	[SerializeField] float loadLevelDelay = 2f;
	[SerializeField] float levelSlowMoFactor = 0.2f;

	private void OnTriggerEnter2D(Collider2D other) {
		StartCoroutine(LoadNextLevel());
	}

	IEnumerator LoadNextLevel() {
		Time.timeScale = levelSlowMoFactor;

		yield return new WaitForSeconds(loadLevelDelay);

		Time.timeScale = 1;

		var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

		SceneManager.LoadScene(currentSceneIndex + 1);
	}
}
