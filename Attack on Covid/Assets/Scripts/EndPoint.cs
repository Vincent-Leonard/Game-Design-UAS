﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //virus keluar dari scene
        Destroy(other.gameObject);
        GameScript.playerLife--;
        EnemySpawn.virusCountGlobal--;
        SoundController.instance.PlaySound(SFXType.DIE);
    }
}
