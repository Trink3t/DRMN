using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScreen : MonoBehaviour
{
    public StateMachine<MainMenuScreen> stateMachine {get; private set;}
    public ViewManager viewManager;
    public ModalWindow modalWindow;
    [HideInInspector] public AccountController accountController = AccountController.Instance;

    [SerializeField] private List<Button> backButtons;
    [SerializeField] private Button optionButton;
    [SerializeField] private Button playerButton;
    [SerializeField] private Button learningMaterialsButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button logoutButton;
    // [SerializeField] private Button 

    private void Start() 
    {
        viewManager = GetComponent<ViewManager>();
        modalWindow = GetComponent<ModalWindow>();

        viewManager.ShowBase();
    }

    public void OnLevelSelectButtonClicked()
    {
        stateMachine.ChangeState(new LevelSelectionState());
    }

    public void OnSettingsButtonClicked()
    {
        stateMachine.ChangeState(new ChangeSettingsState());
    }

    public void OnLearningMaterialsButtonClicked()
    {

    }

    public void OnAccountLogoutButtonClicked()
    {

    }
}
