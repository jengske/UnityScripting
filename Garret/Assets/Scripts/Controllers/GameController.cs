using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public bool isDebug = false;
	// Player info to be saved and drawed on the hud
	#region HealthSystem
	// health
	public int Health = 100;
	private int minHealth = 0;
	private int maxHealth = 100;
	#endregion

	#region ScoreSystem
	public static int Score = 0;
	public int score = Score;

	public static int ObjFound = 0;

	#endregion

	#region toDo

	#endregion
	// make this instance a singleton
	#region Singleton
	public static GameController Default_GC_Instance
	{
		get{return This_GC;}
	}

	private static GameController This_GC = null;
	#endregion

	void Awake()
	{
		if(This_GC != null)
		{
			DestroyImmediate(gameObject);
			return;
		}

		This_GC = this;
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
	if (!isDebug)
		{
			Debug.Log("houston we got it" );
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
