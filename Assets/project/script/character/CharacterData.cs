using UnityEngine;

[RequireComponent(typeof(MoveEngine))]
public class CharacterData : MonoBehaviour
{
	private IMovable moveEngine;
	public IMovable MoveEngine
	{
		get { return ( moveEngine = ( moveEngine ?? GetComponent<IMovable>() ) ); }
	}
}

