using UnityEngine;
using Unity.Entities;

public class PlayerInputComponent : MonoBehaviour {

	public float horizontal;
	public float vertical;
	public float jumpAmount;
	public float jumpCd;

	public bool isGrounded;
	public bool jump;
	public bool canJump => jumpCd <= 0;

}
