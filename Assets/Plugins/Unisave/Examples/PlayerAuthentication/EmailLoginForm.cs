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
    public class EmailLoginForm : MonoBehaviour
    {
        public InputField emailField;
        public InputField passwordField;
        public Button loginButton;
        public Text statusText;
        public GameObject whois;

        public GameObject gamescreen;
        void Start()
        {
            if (emailField == null)
                throw new ArgumentException(
                    $"Link the '{nameof(emailField)}' in the inspector."
                );
        
            if (passwordField == null)
                throw new ArgumentException(
                    $"Link the '{nameof(passwordField)}' in the inspector."
                );
        
            if (loginButton == null)
                throw new ArgumentException(
                    $"Link the '{nameof(loginButton)}' in the inspector."
                );
        
            if (statusText == null)
                throw new ArgumentException(
                    $"Link the '{nameof(statusText)}' in the inspector."
                );
        
            loginButton.onClick.AddListener(OnLoginClicked);

            statusText.enabled = false;
        }

        public async void OnLoginClicked()
        {
            statusText.enabled = true;
            statusText.text = "Logging in...";
        
            var response = await OnFacet<EmailLoginFacet>.CallAsync<bool>(
                nameof(EmailLoginFacet.Login),
                emailField.text,
                passwordField.text
            );

            if (response)
            {
                statusText.text = "Login succeeded";
                whois.GetComponent<WhoIsController>().SaveInfo();
            }
            else
            {
                statusText.text = "Given credentials are not valid";
            }
        }

        public void StartGame()
        {
            //this.transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
            gamescreen.SetActive(true);
        }
    }
}

