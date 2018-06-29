using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exclusionList : MonoBehaviour {
    List<string> pExclusionList = new List<string>() {
        "8e6bcda9-856e-441b-9c24-4169a9843b57",
        "cb00f27f-d492-406b-9a1d-0bbe1377f41a",
        "dbaa94c7-addd-434e-a535-817d81cc0f98",
    "3a2c3ded-7734-4bfc-9b64-c62427ffbd9a",
    "a97f13ad-852a-491c-8280-b6b657521916",
    "404987d5-0b6e-4ad5-9310-3ac57253a3eb",
    "a7ed5faf-dcb8-44fa-967c-99911da1bef0"};
	public bool exclusionListCheck(string ID)
    {
        if (pExclusionList.Contains(ID))
        {
            return true;
        }
        return false;
    }
}
