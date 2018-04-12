using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class testAccessUser : MonoBehaviour {

	public Text myText;

	// List of users
	public static List<User> savedUsers;

	private User localUser; 
	private CurrentUser currentUserRef;
	// Use this for initialization
	void Start () {

		// Need this to setup local environment.
		// currentUserRef is the instance of the GameObject thats keeping the player data throughout scenes
		// localUser is the instance of User that is modified throughout the scene, and will be saved when transitioning. 
		currentUserRef = GameObject.FindObjectOfType<CurrentUser> ();
		localUser = currentUserRef.currentUser;


		// Testing. 
		myText.text = localUser.getName() + " Level: " + localUser.getLevel() ;
		localUser.setLevel (localUser.getLevel () + 1);


		// Will update the User information in the stored data. 
		currentUserRef.Save (localUser);
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}
}
