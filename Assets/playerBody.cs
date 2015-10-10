using UnityEngine;
using System.Collections;

public class playerBody : MonoBehaviour, IBody<GameObject>{
	private float walkSpeed;
	private float curSpeed;
	private float maxSpeed;
	void Start()
	{
		
		curSpeed = 10;
		
	}
	void Update(){
		if (Input.GetKey(KeyCode.A))
		{
			transform.position += Vector3.left * curSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.right * curSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += Vector3.up * curSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position += Vector3.down * curSpeed * Time.deltaTime;
		}
		//Debug.Log("moving");
	}
	public void Move(){
	}
	public void Attack(GameObject enemy){

	}
	public void build(){
	}
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}

}
