using UnityEngine;
using System.Collections;

public class des : MonoBehaviour {

	void OnTriggerStay2D(Collider2D coll) 
	{
		if(coll.name.StartsWith("des"))
		{
			Destroy(coll.gameObject);
		}
		else
		{
			
		}
	}
}
