using UnityEngine;
using Unity.Entities;

public class PlayerInputSystem : ComponentSystem {

	public struct data
	{
		public PlayerInputComponent _inputComponent;
	}

	protected override void OnUpdate()
	{
		foreach(var e in GetEntities<data>())
		{
			e._inputComponent.horizontal = Input.GetAxis("Horizontal");
			e._inputComponent.vertical = Input.GetAxis("Vertical");
		}
	}
}
