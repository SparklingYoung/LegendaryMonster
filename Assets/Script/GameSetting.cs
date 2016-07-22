using UnityEngine;
using System.Collections;

public enum GameLevel{
	LEVEL1,
	LEVEL2,
	LEVEL3,
	LEVEL4,
	LEVEL5
}

public class GameSetting : MonoBehaviour {
	public static GameLevel level = GameLevel.LEVEL1;
}
