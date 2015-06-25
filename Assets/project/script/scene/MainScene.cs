using UnityEngine;
using System.Collections;

public class MainScene : MonoBehaviour
{
	[SerializeField]
	private Camera mainCamera;

	private void Awake()
	{
		Storage.CharacterManager
			.CreateCharacterList(
				GameObject.FindObjectsOfType<CharacterData>()
			);
	}

	private void Update()
	{
		Storage.Update();
	}
}
