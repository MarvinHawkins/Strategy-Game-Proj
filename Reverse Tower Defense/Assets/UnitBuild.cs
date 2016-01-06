using UnityEngine;
using System.Collections;
using System.Collections.Generic; //To have access to the Queue

public class UnitBuild : MonoBehaviour {


	public float numUnits; //keep track of the total number of units built
	public float buildTimer; // create a build timer
	public float maxTimer; //Can use for an upgrade
	public GameObject unitToBuild;
	public  Transform spawnPoint;
	public GameObject[] Units = new GameObject[3]; // create an array of units to hold the built units
	
	// Use this for initialization
	void Start () 
	{
	
		//Start the building with 3 units
		//numUnits = 3;
	}

	
	// Update is called once per frame
	void Update () 
	{
		//Check the total number of units
		for(int i = 0; i <3; i++)
		{
				if(Units[i] == null)
				{
					//Start the build timer
					
				buildTimer -=Time.deltaTime;

				if(buildTimer <= 0)
					{
					buildTimer = 10;
					//Add unit to empty slot
					Units[i] = unitToBuild;

					//create a new unit
					Vector3 newPos = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z);  
					GameObject newUnit = Instantiate(unitToBuild, newPos, transform.rotation) as GameObject;

				
					}	
					
				}

			}

	}




}