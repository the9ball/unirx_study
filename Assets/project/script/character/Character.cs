using UnityEngine;
using System.Collections;

public interface IMovable
{
	Vector3    position { get; }
	Quaternion rotation { get; }

	void WarpTo( Vector3 to );
	void MoveTo( Vector3 to );
	void Move( Vector3 direction );
}

public class Character
{
	public Vector3    position { get { return moveEngine.position; } }
	public Quaternion rotation { get { return moveEngine.rotation; } }

	protected IMovable moveEngine;

	public Character( IMovable moveEngine )
	{
		this.moveEngine = moveEngine;
	}
}

