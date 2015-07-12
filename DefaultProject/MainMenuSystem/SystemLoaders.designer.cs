// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;


public class MainMenuSystemLoaderBase : uFrame.Kernel.SystemLoader {
    
    private MainMenuRootViewModel _MainMenuRoot;
    
    private MainMenuRootController _MainMenuRootController;
    
    private SubScreenController _SubScreenController;
    
    private LoginScreenController _LoginScreenController;
    
    private SettingsScreenController _SettingsScreenController;
    
    private LevelSelectScreenController _LevelSelectScreenController;
    
    private MenuScreenController _MenuScreenController;
    
    [uFrame.IOC.InjectAttribute("MainMenuRoot")]
    public virtual MainMenuRootViewModel MainMenuRoot {
        get {
            if (this._MainMenuRoot == null) {
                this._MainMenuRoot = this.CreateViewModel<MainMenuRootViewModel>( "MainMenuRoot");
            }
            return _MainMenuRoot;
        }
        set {
        }
    }
    
    [uFrame.IOC.InjectAttribute()]
    public virtual MainMenuRootController MainMenuRootController {
        get {
            if (_MainMenuRootController==null) {
                _MainMenuRootController = Container.CreateInstance(typeof(MainMenuRootController)) as MainMenuRootController;;
            }
            return _MainMenuRootController;
        }
        set {
            _MainMenuRootController = value;
        }
    }
    
    [uFrame.IOC.InjectAttribute()]
    public virtual SubScreenController SubScreenController {
        get {
            if (_SubScreenController==null) {
                _SubScreenController = Container.CreateInstance(typeof(SubScreenController)) as SubScreenController;;
            }
            return _SubScreenController;
        }
        set {
            _SubScreenController = value;
        }
    }
    
    [uFrame.IOC.InjectAttribute()]
    public virtual LoginScreenController LoginScreenController {
        get {
            if (_LoginScreenController==null) {
                _LoginScreenController = Container.CreateInstance(typeof(LoginScreenController)) as LoginScreenController;;
            }
            return _LoginScreenController;
        }
        set {
            _LoginScreenController = value;
        }
    }
    
    [uFrame.IOC.InjectAttribute()]
    public virtual SettingsScreenController SettingsScreenController {
        get {
            if (_SettingsScreenController==null) {
                _SettingsScreenController = Container.CreateInstance(typeof(SettingsScreenController)) as SettingsScreenController;;
            }
            return _SettingsScreenController;
        }
        set {
            _SettingsScreenController = value;
        }
    }
    
    [uFrame.IOC.InjectAttribute()]
    public virtual LevelSelectScreenController LevelSelectScreenController {
        get {
            if (_LevelSelectScreenController==null) {
                _LevelSelectScreenController = Container.CreateInstance(typeof(LevelSelectScreenController)) as LevelSelectScreenController;;
            }
            return _LevelSelectScreenController;
        }
        set {
            _LevelSelectScreenController = value;
        }
    }
    
    [uFrame.IOC.InjectAttribute()]
    public virtual MenuScreenController MenuScreenController {
        get {
            if (_MenuScreenController==null) {
                _MenuScreenController = Container.CreateInstance(typeof(MenuScreenController)) as MenuScreenController;;
            }
            return _MenuScreenController;
        }
        set {
            _MenuScreenController = value;
        }
    }
    
    public override void Load() {
        Container.RegisterViewModelManager<MainMenuRootViewModel>(new ViewModelManager<MainMenuRootViewModel>());
        Container.RegisterController<MainMenuRootController>(MainMenuRootController);
        Container.RegisterViewModelManager<SubScreenViewModel>(new ViewModelManager<SubScreenViewModel>());
        Container.RegisterController<SubScreenController>(SubScreenController);
        Container.RegisterViewModelManager<LoginScreenViewModel>(new ViewModelManager<LoginScreenViewModel>());
        Container.RegisterController<LoginScreenController>(LoginScreenController);
        Container.RegisterViewModelManager<SettingsScreenViewModel>(new ViewModelManager<SettingsScreenViewModel>());
        Container.RegisterController<SettingsScreenController>(SettingsScreenController);
        Container.RegisterViewModelManager<LevelSelectScreenViewModel>(new ViewModelManager<LevelSelectScreenViewModel>());
        Container.RegisterController<LevelSelectScreenController>(LevelSelectScreenController);
        Container.RegisterViewModelManager<MenuScreenViewModel>(new ViewModelManager<MenuScreenViewModel>());
        Container.RegisterController<MenuScreenController>(MenuScreenController);
        Container.RegisterViewModel<MainMenuRootViewModel>(MainMenuRoot, "MainMenuRoot");
    }
}
