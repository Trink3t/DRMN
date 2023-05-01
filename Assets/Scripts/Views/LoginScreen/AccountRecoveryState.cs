using System.Collections;

public class AccountRecoveryState : State<LoginScreen>
{
    public override void Enter(LoginScreen loginScreen)
    {
        loginScreen.viewManager.Show("EnterEmail");
        
    }

    public override void Execute(LoginScreen loginScreen)
    {
        if (loginScreen.isSendOTPButtonClicked)
        {
            loginScreen.isSendOTPButtonClicked = false;

            //TODO: Verify Email and send OTP code if true;
            loginScreen.viewManager.Show("EnterOTP");
        }

        if (loginScreen.isVerifyOTPButtonClicked)
        {
            loginScreen.isVerifyOTPButtonClicked = false;
            //TODO: Verify OTP Code and proceed to create password;

            loginScreen.viewManager.Show("EnterNewPassword");
        }

        if (loginScreen.isResetPasswordButtonClicked)
        {
            loginScreen.isResetPasswordButtonClicked = false;
            //TODO: Change password and return to login screen if true;

            loginScreen.StateMachine.ChangeState(null);
            loginScreen.viewManager.ShowBase();
        }
    }

    public override void Exit(LoginScreen loginScreen)
    {
        
    }

    IEnumerator SendCode(string email)
    {
        yield return true;
    }

}
