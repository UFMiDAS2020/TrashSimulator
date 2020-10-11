
using System.Collections;

using System.Collections.Generic;

using TMPro;

using UnityEngine;

using UnityEngine.UI;

using UnityEngine.UIElements;

using Firebase;

using Firebase.Auth;



public class signup : MonoBehaviour
{
    public TMP_Text  emailText, debugText;
    // public UnityEngine.UI.Button signUpButton;
    string email, password;
    Firebase.Auth.FirebaseAuth auth;

    //  DatabaseReference reference;

    // Start is called before the first frame update
    void Start()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        
    }

    public void OnButtonPress()
    {

        //debugText.text = "Button Clicked";

        // email = emailText.text;
        email = "inessaid@gmail.com";
        //password = passText.text;
        password = "Inessaid";

        debugText.text = ("Button Clicked: " + email);


        // Sign up stuff here
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                debugText.text = "CreateUserWithEmailAndPasswordAsync was canceled.";
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                debugText.text = "CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception;
                return;
            }

            // Firebase user has been created.
            Firebase.Auth.FirebaseUser newUser = task.Result;

            //User user = new User(newUser.UserId, firstname, lastname, email);
            //string json = JsonUtility.ToJson(user);

            //reference.Child("users").Child(newUser.UserId).SetRawJsonValueAsync(name);

            Debug.LogFormat("Firebase user created successfully: {0} ({1})", newUser.Email, newUser.UserId);
            // debugText.text = $"Firebase user created successfully: {newUser.DisplayName} ({newUser.UserId})"
        });
        //SceneManager.LoadScene("Menu");

    }

}
