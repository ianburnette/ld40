using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLogic : MonoBehaviour {

    public static SceneLogic publicSceneManagement;
    #region Private Variables
    
#endregion

#region Public Properties

#endregion

#region Unity Functions
	void Start () {
        publicSceneManagement = this;
	}
	
	void Update () {
		
	}
#endregion

#region Custom Functions
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToLobby()
    {

    }
#endregion
}
