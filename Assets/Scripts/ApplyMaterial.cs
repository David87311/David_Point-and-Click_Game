using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyMaterial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance.currentChest != null) 
        { 
        GameObject.Find("Starter_Chest").GetComponent<SkinnedMeshRenderer>().material = GameManager.Instance.currentChest;
        }

        if (GameManager.Instance.currentLegs != null)
        {
            GameObject.Find("Starter_Legs").GetComponent<SkinnedMeshRenderer>().material = GameManager.Instance.currentLegs;
        }

        if (GameManager.Instance.currentBoots != null)
        {
            GameObject.Find("Starter_Boots").GetComponent<SkinnedMeshRenderer>().material = GameManager.Instance.currentBoots;
        }

    }
}
