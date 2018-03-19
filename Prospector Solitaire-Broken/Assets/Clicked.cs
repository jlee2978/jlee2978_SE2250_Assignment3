using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour {
    //public string shareScore = ScoreManager.S.score.ToString();
    private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
    private const string TWITTER_LANG = "en";
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        OnClick();
	}

    void OnClick()
    {
        int shareScore = ScoreManager.S.score;
        Application.OpenURL(TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(shareScore.ToString()));
    }
}
