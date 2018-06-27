using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exclusionList : MonoBehaviour {
    List<string> pExclusionList = new List<string>() {
        "8e6bcda9-856e-441b-9c24-4169a9843b57",
        "cb00f27f-d492-406b-9a1d-0bbe1377f41a" };
	public bool exclusionListCheck(string ID)
    {
        if (pExclusionList.Contains(ID))
        {
            return true;
        }
        return false;
    }
}
