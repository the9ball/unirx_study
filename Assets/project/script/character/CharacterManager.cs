using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class CharacterManager
{
	public List<Character> characterList;

	public void CreateCharacterList(
		IEnumerable<CharacterData> dataList
	)
	{
		characterList = dataList
			.Select( x => CharacterFactory.Create( x ) )
			.ToList();
	}

	public void Update()
	{
		foreach ( var c in characterList ) c.Update();
	}
}

