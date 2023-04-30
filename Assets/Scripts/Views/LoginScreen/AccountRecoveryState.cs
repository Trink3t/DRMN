using System.Collections;

public class AccountRecoveryState : State<LoginScreen>
{
    AccountController AccountController = AccountController.Instance;
    public override void Enter(LoginScreen owner)
    {
        owner.viewManager.Show("EnterEmail");
    }

    public override void Execute(LoginScreen owner)
    {
        if (owner.isSendOTPButtonClicked)
        {
            owner.isSendOTPButtonClicked = false;
            //Execute Sending OTP code to mail.

            owner.viewManager.Show("EnterOTP");
        }

        if (owner.isVerifyOTPButtonClicked)
        {
            owner.isVerifyOTPButtonClicked = false;
            //Execute verifying OTP Code

            owner.viewManager.Show("EnterNewPassword");
        }

        if (owner.isResetPasswordButtonClicked)
        {
            owner.isResetPasswordButtonClicked = false;
            //Execute reset password;

            owner.StateMachine.ChangeState(null);
            owner.viewManager.ShowBase();
        }
    }

    public override void Exit(LoginScreen owner)
    {
        
    }

    IEnumerator SendCode(string email)
    {
        yield return true;
    }

}
