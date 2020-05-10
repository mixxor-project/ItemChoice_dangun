using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private GameObject ItemStore = GameObject.Find("ItemStore");

    public void ItemStoreClick()
    {
        ItemStore.SetActive(true);
    }

    public void ItemClick(int itemNum)
    {
        Debug.Log(itemNum);
    }
}
