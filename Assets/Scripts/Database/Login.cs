using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityNpgsql;

public class Login : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField usernameInput;
    [SerializeField] private TMPro.TMP_InputField passwordInput;
    [SerializeField] private TMPro.TMP_Text errorMessage;
    [SerializeField] private GameObject newUserCanvas;
    private NpgsqlConnection con;

    private void Awake()
    {
        ConnectToDatabase();
    }
    public void ValidateLogin()
    {

    }

    public void NewUser()
    {
        gameObject.SetActive(false);
        newUserCanvas.SetActive(true);
    }

    public void ConnectToDatabase()
    {
        con = new NpgsqlConnection("Server = pgserver.mah.se; User Id = aj7870; Password = mau; database = aj7870");
        con.Open();
    }

}
