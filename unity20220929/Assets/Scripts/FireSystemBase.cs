﻿using UnityEngine;

namespace JAY
{
    /// <summary>
    /// 發射系統基底類別
    /// 生成子彈
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;

        //生成子彈
        private void SpawnBullet()
        {
            // 實例化(物件 座標 角度)
            // 生成 子彈預製物 角度與座標跟子彈生成點相同
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}
