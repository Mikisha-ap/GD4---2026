using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 5f;
	[SerializeField] private float jumpStep = 1f;
	[SerializeField] private float rotateSpeed = 100f;
	private Vector2 lookInput;

	[SerializeField] private GameObject shielVisual;
	private bool isShielding;

	private Vector2 moveInput;
	// Start is called once before the first execution of Update after the MonoBehaviour is created


	// Update is called once per frame
	void Update()
	{
		float yaw = lookInput.x * rotateSpeed * Time.deltaTime;
		transform.Rotate(0f, yaw, 0f, Space.World);

		Vector3 move3 = new Vector3(moveInput.x, 0f, moveInput.y) * moveSpeed * Time.deltaTime;
		transform.position += move3;
	}

	public void OnMovement(InputAction.CallbackContext context)
	{
		moveInput = context.ReadValue<Vector2>();
	}

	public void OnLook(InputAction.CallbackContext context)
	{
		lookInput = context.ReadValue<Vector2>();
	}

	public void OnJump(InputAction.CallbackContext context)
	{
		if (!context.performed) return;
		transform.position += Vector3.up * jumpStep;
	}

	public void OnShield(InputAction.CallbackContext context)
	{
		isShielding = context.ReadValueAsButton();
		shielVisual.SetActive(isShielding);
	}
}
