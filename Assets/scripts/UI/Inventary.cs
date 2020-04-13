using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventary : MonoBehaviour
{
    
    public List<Item> PickedItems;
    public GameObject CellPrefab;
    public AudioSource Source;
    

    void Start()
    {
        var rt = GetComponent<RectTransform>();
        foreach (var item in PickedItems)
        {
            var go = Instantiate(CellPrefab,  transform);

            go.GetComponent<ItemPresenter>().Present(item, rt, rt.parent.GetComponent<RectTransform>(), Source);
    }
    }

    
}
