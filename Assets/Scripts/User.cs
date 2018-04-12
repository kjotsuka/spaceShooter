using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class User{

	private string name;
	private int level;
	private int score;
	private int currency;
	private int life;
	private int rateOfFire;
	private int speed;
	private int maxHealth;

	// Registering a new user.
	public User(string name)
	{
		// Set the user's username.
		this.name = name;

		// Initial level will be 1.
		this.level = 1;	

		// Start score from 0.
		this.score = 0;	

		// Start currency from 0.
		this.currency = 0;	

		// Start life from 3.
		this.life = 3;

		// Start rate of fire from 1.
		this.rateOfFire = 1;

		// Start speed at 1.
		this.speed = 1;

		// Start max health at 3.
		this.maxHealth = 3;

	}

	public string getName()
	{
		return this.name;
	}

	public void setName(string name)
	{
		this.name = name;
	}

	public int getLevel()
	{
		return this.level;
	}

	public void setLevel(int level)
	{
		this.level = level;
	}

	public int getScore()
	{
		return this.score;
	}

	public void setScore(int score)
	{
		this.score = score;	
	}

	public int getCurrency()
	{
		return this.currency;
	}

	public void setCurrency(int currency)
	{
		this.currency = currency;
	}

	public int getLife()
	{	
		return this.life;
	}

	public void setLife(int life)
	{
		this.life = life;
	}

	public int getRateOfFire()
	{
		return this.rateOfFire;
	}

	public void setRateOfFire(int rateOfFire)
	{
		this.rateOfFire = rateOfFire;
	}

	public int getSpeed()
	{
		return this.speed;
	}

	public void setSpeed(int speed)
	{
		this.speed = speed;
	}

	public int getMaxHealth()
	{
		return this.maxHealth;
	}

	public void setMaxHealth(int maxHealth)
	{
		this.maxHealth = maxHealth;
	}

}
