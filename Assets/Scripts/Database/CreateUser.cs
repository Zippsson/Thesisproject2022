using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityNpgsql;

public class CreateUser : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField usernameInput;
    [SerializeField] private TMPro.TMP_InputField passwordInput;
    [SerializeField] private TMPro.TMP_InputField validatePasswordInput;
    NpgsqlConnection conn;

    public void CreateUserFromInput()
    {
        
    }
}
