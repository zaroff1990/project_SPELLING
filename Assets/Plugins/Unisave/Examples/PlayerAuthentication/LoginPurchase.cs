using System;
using Unisave.Examples.PlayerAuthentication.Backend.EmailAuthentication;
using Unisave.Facades;
using UnityEngine;
using UnityEngine.UI;

/*
 * EmailAuthentication template - v0.9.1
 * -------------------------------------
 *
 * This script controls the login form and makes login requests.
 *
 * Reference required UI elements and specify what scene to load after login.
 */

namespace Unisave.Examples.PlayerAuthentication
{
    public class LoginPurchase : MonoBehaviour
    {
        public GameObject whois;

        private void OnEnable()
        {
            whois.GetComponent<WhoIsController>().SendInfo();
        }
    }
}

