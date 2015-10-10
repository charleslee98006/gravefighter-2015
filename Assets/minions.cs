using UnityEngine;
using System.Collections;

public class minions : MonoBehaviour,IBody<GameObject>, IBodydamage<int> {
	int health;
	int attack;
	// Use this for initialization
	public void Attack(GameObject enemy){
	}
	public void Move(){
	}
	public void DamageTaken(int damage){
		health -= damage;
		if (health <= 0) {
		}
	}
}
