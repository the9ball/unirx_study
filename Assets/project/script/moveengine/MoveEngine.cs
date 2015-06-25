using UnityEngine;

public class MoveEngine : MonoBehaviour, IMovable
{
	public Vector3    position { get { return this.transform.position; } }
	public Quaternion rotation { get { return this.transform.rotation; } }

	public void WarpTo( Vector3 to )
	{
		transform.position = to;
	}

	public void MoveTo( Vector3 to )
	{
		transform.position = to;
	}

	public void Move( Vector3 direction )
	{
		transform.position += direction;
	}
}
