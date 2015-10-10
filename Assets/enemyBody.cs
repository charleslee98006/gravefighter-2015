using UnityEngine;
using System.Collections;

public class enemyBody : MonoBehaviour, IBody<GameObject>, IBodydamage<int> {
	int health;
	int attack;
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
