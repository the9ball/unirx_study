using UnityEngine;
using System.Collections;

public interface IMovable
{
	Vector3    position { get; }
	Quaternion rotation { get; }

	void Update();

	void WarpTo( Vector3 to );
	void MoveTo( Vector3 to );
	void Move( Vector3 direction );
}

public interface ICharacter
{
}

public class Character : ICharacter
{
	public Vector3    position { get { return moveEngine.position; } }
	public Quaternion rotation { get { return moveEngine.rotation; } }

	protected IMovable moveEngine;

	public Character( IMovable moveEngine )
	{
		this.moveEngine = moveEngine;
	}

	public virtual void Update()
	{
		this.moveEngine.Update();
	}
}

