using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour {

    #region Private Variables
    [SerializeField] float minHeight, checkTime;
    [SerializeField] PlayerLife life;
#endregion

#region Public Properties

#endregion

#region Unity Functions
	void Start () {
        InvokeRepeating("CheckForDeath", checkTime, checkTime);
	}
	
	void Update () {
		
	}
#endregion

#region Custom Functions
    void CheckForDeath()
    {
        if (transform.position.y < minHeight)
        {
            life.End(DeathType.fall);
        }
    }
#endregion
}
