using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
	public Transform sword, sword_ueq, sword_eq;
	public bool sword_is_equipped;
	Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Z))
			anim.SetTrigger("Sword(Equip/Unequip)");
		if (sword_is_equipped)
		{
			sword.position = sword_eq.position;
			sword.rotation = sword_eq.rotation;
		}
		else
		{
			sword.position = sword_ueq.position;
			sword.rotation = sword_ueq.rotation;
		}
	}
	public void Sword_Equip()
	{
		sword_is_equipped = true;
	}
	public void Sword_Unequiped()
	{
		sword_is_equipped = false;
	}
}
