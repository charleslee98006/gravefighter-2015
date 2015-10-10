using UnityEngine;
using System.Collections;
public interface IBody<J>{
		void Attack(J enemy);
		void Move();
		void Regenerate();
}



	