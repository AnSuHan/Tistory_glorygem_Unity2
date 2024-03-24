using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;

public class Login : MonoBehaviour
{
    private FirebaseAuth auth;

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                auth = FirebaseAuth.DefaultInstance;
            }
            else
            {
                Debug.LogError("Could not resolve Firebase dependencies: " + task.Exception);
                return;
            }
        });
    }

    public void Register_Email()
    {
        auth.CreateUserWithEmailAndPasswordAsync("inputEmail@gmail.com", "inputPassword");
    }

    public void Login_Email()
    {
        auth.SignInWithEmailAndPasswordAsync("inputEmail@gmail.com", "inputPassword");
    }

    public void Login_Anonymous()
    {
        auth.SignInAnonymouslyAsync();
    }
}
