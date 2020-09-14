﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellPriceRefinery : MonoBehaviour
{
    public int minSellPriceOil;
    public int maxSellPriceOil;

    [Min(30)]
    public int roughChangeTime;

    private float oldSellPriceOil = 1;
    [HideInInspector]
<<<<<<< HEAD
    public float sellPriceOil;
    private int targetSellPriceOil = 2;
=======
    public float sellPriceOil = 2;
    private int targetSellPriceOil;
>>>>>>> parent of 607d604... Revert "proj luc"


    int randomDelayOil = 0;
    private float secondcounterOil = 0;


    void Update()
    {
        UpdateOilPrice();
    }

    void UpdateOilPrice()
    {
        secondcounterOil += Time.deltaTime;
        if (secondcounterOil > roughChangeTime + randomDelayOil)
        {
            randomDelayOil = Random.Range(-30, 60);
            secondcounterOil = 0;
            targetSellPriceOil = Random.Range(minSellPriceOil, maxSellPriceOil);
            oldSellPriceOil = sellPriceOil;
        }
        sellPriceOil = Mathf.Lerp(oldSellPriceOil, targetSellPriceOil, secondcounterOil / (roughChangeTime + randomDelayOil));
    }
}