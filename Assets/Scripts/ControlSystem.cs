using UnityEngine;

public class ControlSystem : MonoBehaviour
{
	[Header("���ʳt��"),Range(0.5f,9.9f)]
	public float movespeed = 3.5f;

	[Header("2D ����")]
	public Rigidbody2D rig;

	private void Awake()
	{
		print("hellowworld");
		print("x+x");
	}
	private void Start()
	{
		print("<color=red>�}�l");

	}
	private void Update()
	{
		print("��s");
	}
}
