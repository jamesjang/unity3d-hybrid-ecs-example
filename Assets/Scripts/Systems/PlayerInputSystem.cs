using UnityEngine;
using Unity.Entities;

public class PlayerInputSystem : ComponentSystem {

	public struct data
	{
		public PlayerInputComponent _inputComponent;
	}

	protected override void OnUpdate()
	{
		var _dt = Time.deltaTime;
		
		foreach(var e in GetEntities<data>())
		{
			var _playerInput = e._inputComponent;

			_playerInput.horizontal = Input.GetAxis("Horizontal");
			_playerInput.vertical = Input.GetAxis("Vertical");
			_playerInput.jump = Input.GetKeyDown("space");

			_playerInput.jumpCd = Mathf.Max(0.0f, _playerInput.jumpCd - _dt);
		}
	}

}
