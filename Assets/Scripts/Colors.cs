using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{

    public Material[] materials;
    public int Chest, Legs, Boots = 0;




    public void ChangeColor(string bodypart)
    {
        if (bodypart == "Starter_Chest")
        {
            Chest += 1;

            if (Chest >= materials.Length)
            {
                Chest = 0;
            }

            else if (Chest < 0) 
            {
                Chest = materials.Length - 1;
            }

            GameObject.Find(bodypart).GetComponent<SkinnedMeshRenderer>().material = materials[Chest];
            GameManager.Instance.changeMaterial();


        }

        else if (bodypart == "Starter_Legs")
        {
            Legs += 1;

            if (Legs >= materials.Length)
            {
                Legs = 0;
            }

            else if (Legs < 0)
            {
                Legs = materials.Length - 1;
            }


            GameObject.Find(bodypart).GetComponent<SkinnedMeshRenderer>().material = materials[Legs];
            GameManager.Instance.changeMaterial();
        }

        else if (bodypart == "Starter_Boots")
        {
            Boots += 1;

            if (Boots >= materials.Length)
            {
                Boots = 0;
            }

            else if (Boots < 0)
            {
                Boots = materials.Length - 1;
            }


            GameObject.Find(bodypart).GetComponent<SkinnedMeshRenderer>().material = materials[Boots];
            GameManager.Instance.changeMaterial();
        }



    }


}
