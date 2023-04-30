using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountController : Singleton<AccountController>
{
    private PlayerData playerData;

    public bool LoadData()
    {
        return true;
    }
}
