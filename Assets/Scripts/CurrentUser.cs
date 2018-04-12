using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class CurrentUser : MonoBehaviour {

	public User currentUser;

	// List of users
	public static List<User> savedUsers;

	public CurrentUser(User user)
	{
		this.currentUser = user;
	}

	void Awake() 
	{
		DontDestroyOnLoad (this.gameObject);
	}
		
	//it's static so we can call it from anywhere
	public void Save(User user) 
	{
		Load ();
		// Find the original instance of the user from the saved users list.
		User overwriteUser = savedUsers.Find(searchUser => searchUser.getName() == user.getName());

		// Remove the original copy of the user with the original values.
		savedUsers.Remove (overwriteUser);

		// Add the user with the updated information.
		savedUsers.Add (user);

		BinaryFormatter bf = new BinaryFormatter();
		//Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd"); //you can call it anything you want
		bf.Serialize(file, savedUsers);
		file.Close();
	}   

	public static void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) 
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			savedUsers = (List<User>)bf.Deserialize(file);
			file.Close();
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
