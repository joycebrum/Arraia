using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {
    public int colums;
    public int rows;
    public GameObject floor;
    public GameObject Barreira;
    public GameObject[] Barraca;
    private Transform boardHolder;
	// Use this for initialization
    void BoardSetup ()
    {
        boardHolder = new GameObject("Holder").transform;
        for(int x = -1; x < colums +1; x++)
        {
            for(int y = -1; y < rows+1; y++)
            {
                GameObject toInstanciate = floor;
                if(x==-1 || y==-1 || x==colums || y==rows)
                {
                    toInstanciate = Barreira;
                }
                GameObject instance = Instantiate(toInstanciate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);
            }
        }
    }
	void Barracasetup()
    {
        Vector3 position = new Vector3(0f, rows / 2, 0f);
        Instantiate(Barraca[0], position, Quaternion.identity);
        position.x = colums - 1;
        Instantiate(Barraca[1], position, Quaternion.identity);
        position.x = colums / 2;
        position.y = 0;
        Instantiate(Barraca[2], position, Quaternion.identity);
        position.y = rows - 1;
        Instantiate(Barraca[3], position, Quaternion.identity);
    }
    public void SetupCity()
    {
        BoardSetup();
        Barracasetup();
    }
}
