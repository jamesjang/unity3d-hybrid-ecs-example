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
			var moveVector = new Vector3(e._inputComponent.horizontal, 0, e._inputComponent.vertical);
			var movePosition = e._rigidbody.position + moveVector.normalized * 3 * dt;

			e._rigidbody.MovePosition(movePosition);
		}
	}
}
