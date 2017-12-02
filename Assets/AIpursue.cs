using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIpursue : MonoBehaviour {

    #region Private Variables
    [SerializeField] Transform currentTarget;
    [SerializeField] NavMeshAgent agent;
#endregion

#region Public Properties

#endregion

#region Unity Functions
	void Start () {
		
	}
	
	void Update () {
        if (currentTarget!=null)
        {
            agent.destination = currentTarget.position;
        }
	}
#endregion

#region Custom Functions

#endregion
}
