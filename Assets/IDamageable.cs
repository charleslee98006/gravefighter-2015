using UnityEngine;
using System.Collections;

public interface IDamageable<T>{
	void DamageTaken(T damage);
}
