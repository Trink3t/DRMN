using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginScreen : MonoBehaviour
{
    public StateMachine<LoginScreen> StateMachine {get; private set;}
    
    public ViewManager viewManager;
    public ModalWindow modalWindow;

    public string username {get; private set;}
    public string password {get; private set;}

    public int otp {get; private set;}
    public string email {get; private set;}

    public bool isSendOTPButtonClicked {get; set;}
    public bool isVerifyOTPButtonClicked {get; set;}
    public bool isResetPasswordButtonClicked {get; set;}

    [SerializeField] private TMP_InputField _username;
    [SerializeField] private TMP_InputField _password;

    [SerializeField] private TMP_InputField _otp;
    [SerializeField] private TMP_InputField _email;

    

    private void Start() 
    {
        isResetPasswordButtonClicked = false;
        isSendOTPButtonClicked = false;
        isVerifyOTPButtonClicked = false;

        StateMachine = new StateMachine<LoginScreen>(this);
        viewManager = GetComponent<ViewManager>();
        modalWindow = GetComponent<ModalWindow>();

        viewManager.ShowBase();
    }

    private void Update() 
    {
        StateMachine.Update();
    }

    public void OnLoginButtonClicked()
    {
        username = _username.text;
        password = _password.text;

        StateMachine.ChangeState(new LoggingInState());
    }

    public void OnForgotPasswordButtonClicked()
    {
        StateMachine.ChangeState(new AccountRecoveryState());
    }

    public void OnSendOTPButtonClicked()
    {
        isSendOTPButtonClicked = true;
    }

    public void OnVerifyOTPButtonClicked()
    {
        isVerifyOTPButtonClicked = true;
    }

    public void OnResetPasswordButtonClicked()
    {
        isResetPasswordButtonClicked = true;
    }
}
