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

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
