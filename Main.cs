using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GorillaLocomotion;
using GorillaNetworking;
using MelonLoader;
using Photon.Pun;
using Photon.Realtime;
using easyInputs;
using UnityEngine;
using static BetterPlayers.Plugin;

namespace BetterPlayers
{
    public class Main
    {
        public static void ImJustFastBro()
        {
            if (Plugin.ImJustFastBro)
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.jumpMultiplier = 8.4f;
                    GorillaLocomotion.Player.Instance.maxJumpSpeed = 8.6f;
                }
                else
                {
                    GorillaLocomotion.Player.Instance.jumpMultiplier = 1.0f;
                    GorillaLocomotion.Player.Instance.maxJumpSpeed = 3.7f;
                }
            }
        }

        public static void ImNotUsingPSA()
        {
            if (Plugin.ImNotUsingPSA)
            {
                if (EasyInputs.GetThumbStickButtonDown(EasyHand.LeftHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.bodyCollider.transform.forward * 7.8f * Time.deltaTime;
                }
            }
        }

        public static float PlatformCooldown;
        public static float PlatformCooldown2;
        public static GameObject rightHandPlatform;
        public static GameObject leftHandPlatform;

        public static void ICanGetOutTheMap()
        {
            if (Plugin.ICanGetOutTheMap)
            {
                bool LeftGripDown = EasyInputs.GetGripButtonDown(EasyHand.LeftHand);
                bool RightGripDown = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
                bool JoyStickDown = EasyInputs.GetThumbStickButtonDown(EasyHand.RightHand); // Just so you can do platform checks
                if (PlatformCooldown == 0f && RightGripDown && JoyStickDown)
                {
                    PlatformCooldown = 1f;
                    rightHandPlatform = new GameObject();
                    rightHandPlatform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    rightHandPlatform.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
                    UnityEngine.Object.Destroy(rightHandPlatform.GetComponent<Rigidbody>());
                    rightHandPlatform.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
                    rightHandPlatform.transform.position = new Vector3(0f, -0.0075f, 0f) + GorillaLocomotion.Player.Instance.rightHandTransform.position;
                    rightHandPlatform.transform.rotation = GorillaLocomotion.Player.Instance.rightHandTransform.rotation;
                }
                else if (PlatformCooldown == 1f && !RightGripDown && !JoyStickDown)
                {
                    PlatformCooldown = 0f;
                    UnityEngine.Object.DestroyImmediate(rightHandPlatform);
                    UnityEngine.Object.DestroyImmediate(rightHandPlatform.gameObject);
                    UnityEngine.Object.Destroy(rightHandPlatform);
                    UnityEngine.Object.Destroy(rightHandPlatform.gameObject);
                    rightHandPlatform = null;
                }
                if (PlatformCooldown2 == 0f && LeftGripDown && JoyStickDown)
                {
                    PlatformCooldown2 = 1f;
                    leftHandPlatform = new GameObject();
                    leftHandPlatform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    leftHandPlatform.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
                    UnityEngine.Object.Destroy(leftHandPlatform.GetComponent<Rigidbody>());
                    leftHandPlatform.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
                    leftHandPlatform.transform.position = new Vector3(0f, -0.0075f, 0f) + GorillaLocomotion.Player.Instance.leftHandTransform.position;
                    leftHandPlatform.transform.rotation = GorillaLocomotion.Player.Instance.leftHandTransform.rotation;
                    return;
                }
                if (PlatformCooldown2 == 1f && !LeftGripDown && !JoyStickDown)
                {
                    PlatformCooldown2 = 0f;
                    UnityEngine.Object.DestroyImmediate(leftHandPlatform);
                    UnityEngine.Object.DestroyImmediate(leftHandPlatform.gameObject);
                    UnityEngine.Object.Destroy(leftHandPlatform);
                    UnityEngine.Object.Destroy(leftHandPlatform.gameObject);
                    leftHandPlatform = null;
                }
            }
        }
    }
}
