using UnityEngine;
using Unity.Entities;

public class PlayerMoveSystem : ComponentSystem {

	public struct data 
	{
		public PlayerInputComponent _inputComponent;
		public Rigidbody _rigidbody;
	}


	protected override void OnUpdate()
	{
		var dt = Time.deltaTime;
		
		foreach(var e in GetEntities<data>())
		{
			var _playerInput = e._inputComponent;


			var moveVector = new Vector3(_playerInput.horizontal, e._rigidbody.position.y, _playerInput.vertical);
			var movePosition = e._rigidbody.position + moveVector.normalized * 3 * dt;

			e._rigidbody.MovePosition(movePosition);

			if (_playerInput.jump)
			{
				if (_playerInput.canJump)
				{
					e._rigidbody.AddForce(Vector3.up * e._inputComponent.jumpAmount);
					_playerInput.jumpCd = 2.0f;
				}
			}

		}
	}


}
