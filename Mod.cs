using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Kitchen;
using KitchenMods;
using UnityEngine;
using Unity.Collections;
using Unity.Entities;
using KitchenLib;
using Cinemachine;
using HarmonyLib;

namespace FirstPersonMod
{
    public class firstPerson : GenericSystemBase, IModSystem
    {
        

        protected override void Initialise()
        {
            base.Initialise();
            CinemachineBrain[] brains = GameObject.FindObjectsOfType<CinemachineBrain>();
            foreach(CinemachineBrain brain in brains)
            {
                brain.enabled = false;
            }
        }

        

        protected override void OnUpdate()
        {
            throw new NotImplementedException();
            
        }
    }
}