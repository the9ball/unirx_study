public static class CharacterFactory
{
	public static Character Create( CharacterData data )
	{
		return new Character( data.MoveEngine );
	}
}

