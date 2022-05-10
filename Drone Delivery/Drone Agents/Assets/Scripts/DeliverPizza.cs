using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverPizza : MonoBehaviour
{
    public Transform pizza;
    public GameObject[] struts;
    public void DropPizza()
    {
        pizza.parent = null;
        for (int i = 0; i < struts.Length; i++)
        {
            struts[i].SetActive(false);
        }
    }
}
