using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Material currentChest, currentLegs, currentBoots;


    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void changeMaterial() 
    {
        currentChest = GameObject.Find("Starter_Chest").GetComponent<SkinnedMeshRenderer>().material;

        currentLegs = GameObject.Find("Starter_Legs").GetComponent<SkinnedMeshRenderer>().material;

        currentBoots = GameObject.Find("Starter_Boots").GetComponent<SkinnedMeshRenderer>().material;
    }

}
