using UnityEngine;
using System.Collections;
public interface IBody<J>{
		void Attack(J enemy);
		void Move();


}
public interface IBodydamage<T>{
		void DamageTaken(T damage);
}
	