using UnityEngine;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

public class Game : MonoBehaviour 
{

	Vector2 dir = Vector2.right;
	public GameObject tailPrefab;
	bool ate = false;

	List<Transform> tail = new List<Transform>();

	void Start () 
	{
		InvokeRepeating("Move", 0.1f, 0.1f);
	}
	

	void Update () 
	{
		test();
	//	Move();
	}

	void Move() {

		Vector2 v = transform.position;
		

		transform.Translate(dir);
		

		if (ate) {

			GameObject g =(GameObject)Instantiate(tailPrefab,v,Quaternion.identity);
			

			tail.Insert(0, g.transform);
			

			ate = false;
		}

		else if (tail.Count > 0) {

			tail.Last().position = v;
			

			tail.Insert(0, tail.Last());
			tail.RemoveAt(tail.Count-1);
		}
	}
	void  test()
	{
		if (Input.GetKey(KeyCode.RightArrow))
			dir = Vector2.right;
		else if (Input.GetKey(KeyCode.DownArrow))
			dir = -Vector2.up;    
		else if (Input.GetKey(KeyCode.LeftArrow))
			dir = -Vector2.right; 
		else if (Input.GetKey(KeyCode.UpArrow))
			dir = Vector2.up;
	}
	void OnTriggerEnter2D(Collider2D coll) 
	{

		if (coll.name.StartsWith("BorderTop")){
			ate = true;
		}
		if (coll.name.StartsWith("BorderDowe")){
			ate = true;
		}
		if (coll.name.StartsWith("BorderLeft")){
			ate = true;
		}
		if (coll.name.StartsWith("BorderRight")){
			ate = true;
		}

		else {
			
			}
		}

		
	}
//if(des.gameObject.tag == "Player")
//{
//	Destroy(des.gameObject);
//	Debug.Log("Player");
//}


