using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TwoPlayersOneKeyboard : MonoBehaviour
{
	[Header("Actions (drag from your Inout Action asset")]
	[SerializeField] private InputActionReference p1Move;
	[SerializeField] private InputActionReference p2Move;

	[Header("Players")]
	[SerializeField] private Transform p1;
	[SerializeField] private Transform p2;
	[SerializeField] private GameObject player1;
	[SerializeField] private GameObject player2;

	[SerializeField] private float speed = 5f;

	[Header("Jumping")]
	[SerializeField] private InputActionReference p1Jump;
	[SerializeField] private InputActionReference p2Jump;

	[SerializeField] private float jumpHeight = 10f;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	private void OnEnable()
	{
		p1Move.action.Enable();
		p2Move.action.Enable();

		p1Jump.action.Enable();
		p2Jump.action.Enable();

	}

	private void OnDisable()
	{
		p1Move.action.Disable();
		p2Move.action.Disable();

		p1Jump.action.Disable();
		p2Jump.action.Disable();
	}

	//private void Jump(InputAction.CallbackContext context)
	//{
	//	if (p1Jump != null) { Debug.Log("Spacebar pressed"); }
	//	if (p2Jump != null) { Debug.Log(""); }
	//}
	// Update is called once per frame
	void Update()
	{
		var m1 = p1Move.action.ReadValue<Vector2>();
		var m2 = p2Move.action.ReadValue<Vector2>();

		var j1 = p1Jump.action.ReadValue<float>();
		var j2 = p2Jump.action.ReadValue<float>();

		if (p1)	p1.position += new Vector3(m1.x, 0f, m1.y) * speed * Time.deltaTime;
		if(player1) p1.position += new Vector3(0f, j1, 0f) * jumpHeight * Time.deltaTime;

		if (p2) p2.position += new Vector3(m2.x, 0f, m2.y) * speed * Time.deltaTime;
		if (player2) p2.position += new Vector3(0f, j2, 0f) * jumpHeight * Time.deltaTime;
	}
}
