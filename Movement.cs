using System;
using System.Collections.Generic;
using System.Text;
using GorillaLocomotion;
using Oculus.Platform;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

namespace StupidTemplate.Mods
{
    internal class Movement
    {
        public static void speedboost()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 9f;
        }

        public static void Rightgripfly()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += (GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        public static void UpdateClipColliders(bool enabled)
        {
            foreach (MeshCollider v in Resources.FindObjectsOfTypeAll<MeshCollider>())
                v.enabled = enabled;
        }


        public static bool noclipflyepic;
        public static void noclipfly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GTPlayer.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * 15;
                GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
                if (noclipflyepic == false)
                {
                    noclipflyepic = true;
                    UpdateClipColliders(false);
                }
                else
                {
                    if (noclipflyepic == true)
                    {
                        noclipflyepic = false;
                        UpdateClipColliders(true);
                    }
                }
            }      } 


        public static void longarms1()
        {
            bool isPressed = ControllerInputPoller.instance.rightControllerSecondaryButton;
 
            bool buttonpressed = false;

            if (!ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                buttonpressed = true;
            }
            else if (buttonpressed == false)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.localScale = new Vector3(1, 1, 1);
            }
            
        }


        public static void platforms()
        {

        }




       


        
        public static void longarms2()
        {
            GTPlayer.Instance.transform.localScale = new Vector3(1,1,1);
        }



        public static void Ghostmonke()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton || Mouse.current.rightButton.isPressed)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        
        public static void upsidedownhead()
        {
            VRRig.LocalRig.head.trackingPositionOffset.z = 180f;



        }



public static void disableupsidedownhead() {
VRRig.LocalRig.head.trackingPositionOffset.z  = 0f;


}

        public static void noclip()
        { 
            bool DisableColliders = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();

            foreach (MeshCollider collider in colliders)
            {
                collider.enabled = DisableColliders;
            }
        }

        public static void Fly()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += (GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
   

