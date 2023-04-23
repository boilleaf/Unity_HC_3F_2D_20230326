using UnityEngine;

public class ControlSystem : MonoBehaviour
{
	[Header("移動速度"),Range(0.5f,9.9f)]
	public float movespeed = 3.5f;

	[Header("2D 鋼體")]
	public Rigidbody2D rig;

	private void Awake()
	{
		print("hellowworld");
		print("x+x");
	}
	private void Start()
	{
		print("<color=red>開始");

	}
	private void Update()
	{
		print("更新");
	}
}
