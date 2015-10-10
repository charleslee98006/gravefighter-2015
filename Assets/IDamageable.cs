using UnityEngine;
using System.Collections;

public interface IDamageable<T>{
	bool isDestroyed();
	void DamageTaken(T damage);
}
