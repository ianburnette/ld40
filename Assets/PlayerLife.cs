using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DeathType{
    fall, 
    shot
}

public class PlayerLife : MonoBehaviour {

#region Private Variables

#endregion

#region Public Properties

#endregion

#region Unity Functions
	void Start () {
		
	}
	
	void Update () {
		
	}
#endregion

#region Custom Functions
    public void End(DeathType howPlayerDied)
    {
        print("player died because of " + howPlayerDied);

        if (howPlayerDied == DeathType.fall)
        {
            SceneLogic.publicSceneManagement.RestartScene();
        }
    }
#endregion
}
