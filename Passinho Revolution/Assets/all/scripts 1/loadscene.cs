using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadscene : MonoBehaviour {

	public void loadByIndex(int sceneindex)
    {
        SceneManager.LoadScene(sceneindex);
    }
}
