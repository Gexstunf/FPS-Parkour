using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_InputField InputMoney;
    public DineroManager dineroManager;

    // Update is called once per frame
    void Update()
    {
        InputMoney.text = dineroManager.playerMoney.ToString();
    }
}
