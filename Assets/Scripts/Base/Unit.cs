using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
	private float BaseHealth = 100;
	private float BaseStamina = 100;
	private float BaseDamage = 100;
	public float Health;
	public float Stamina;
	public float Damage;
	
	[Range(0f,10f)]
	public float speed = 1;

	
	// Use this for initialization
	public void Start () {
		SetModifiers(0,0,0);
	}
	

	public void Move(float angle)
	{
		if (this.transform.rotation != Quaternion.Euler(0, 0, angle))
		{
			this.transform.rotation = Quaternion.Euler(0,0,angle);
		}

		this.transform.position += this.transform.up * Time.deltaTime * speed;
	}

	public void AttackMove(Transform objective, Transform Unit)
	{
		Unit.position += speed * (objective.position - Unit.position).normalized * Time.deltaTime;
	 	Unit.rotation = LookAt2D.LookAt(objective, Unit);
	}

	public void SetModifiers(float healthModifier, float staminaModifier, float damageModifier)
	{
		print("Set modifiers");
		Health += BaseHealth + (BaseHealth * (healthModifier / 100));
		Stamina += BaseStamina + (BaseStamina * (staminaModifier / 100));
		Damage += BaseDamage + (BaseDamage * (damageModifier / 100));
	
	}
}

public class ExpAttributes()
{
	
}
