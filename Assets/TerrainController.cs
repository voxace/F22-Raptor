using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour {

    public GameObject terrain1;
    public GameObject terrain2;
    public GameObject terrain3;
    public float terrainSpeed = 150f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        terrain1.transform.Translate(0f, 0f, -terrainSpeed * Time.deltaTime);
        terrain2.transform.Translate(0f, 0f, -terrainSpeed * Time.deltaTime);
        terrain3.transform.Translate(0f, 0f, -terrainSpeed * Time.deltaTime);

        if (terrain1.transform.position.z < -2500)
        {
            terrain1.transform.position = new Vector3(-1000f, -160f, 5000f);
        }
        if (terrain2.transform.position.z < -2500)
        {
            terrain2.transform.position = new Vector3(-1000f, -160f, 5000f);
        }
        if (terrain3.transform.position.z < -2500)
        {
            terrain3.transform.position = new Vector3(-1000f, -160f, 5000f);
        }

    }
}
