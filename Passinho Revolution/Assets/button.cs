using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class button : MonoBehaviour {
    public void rematch(string rematchgame)
    {
        EditorSceneManager.LoadScene(rematchgame);
    }
}
