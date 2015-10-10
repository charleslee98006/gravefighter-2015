using UnityEngine;
using System.Collections;

public class enemyBody : MonoBehaviour, IBody<GameObject>, IDamageable<int> {
	public int health;
	public int attack;
	private bool isAttacking;
	private float attackInterval;
	private float maxAttackInterval;
	
	private float moveSpeed;
	
	public GameObject currentTarget;

	void update()
	{
		if (!isAttacking) 
		{
			// find nearest gravestone/player body and attack
			// avoid targets already being attacked.
			// mark the target as being attacked. (max attacker count on an object = 4?)
			isAttacking = true;
		} 
		if (true/* next to player body or gravestone */) 
		{
			onAttack ();
		} 
		else 
		{ // need to move towards a target
			onMoveToTarget ();
		}
		
	}

	public void Attack(GameObject enemy){
	}

	public void Move(){
	}

	public void DamageTaken(int damage){
		health -= damage;
		if (health <= 0) {
		}
	}

	void onAttack()
	{
		attackInterval -= Time.deltaTime;
		if(attackInterval <= 0)
		{
			attackTarget();
			attackInterval = maxAttackInterval;
		}
	}
	void onMoveToTarget()
	{
		// move towards the selected target.
	}
}
