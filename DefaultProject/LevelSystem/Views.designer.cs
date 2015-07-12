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
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Services;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UniRx;
using UnityEngine;


public class LevelRootViewBase : uFrame.MVVM.ViewBase {
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public LevelDescriptor _CurrentLevel;
    
    [UFToggleGroup("FinishCurrentLevel")]
    [UnityEngine.HideInInspector()]
    public bool _BindFinishCurrentLevel = true;
    
    [UFGroup("FinishCurrentLevel")]
    [UnityEngine.SerializeField()]
    [UnityEngine.HideInInspector()]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute("_FinishCurrentLevelbutton")]
    protected UnityEngine.UI.Button _FinishCurrentLevelButton;
    
    public override string DefaultIdentifier {
        get {
            return base.DefaultIdentifier;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(LevelRootViewModel);
        }
    }
    
    public LevelRootViewModel LevelRoot {
        get {
            return (LevelRootViewModel)ViewModelObject;
        }
    }
    
    protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as LevelRootViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        var levelrootview = ((LevelRootViewModel)model);
        levelrootview.CurrentLevel = this._CurrentLevel;
    }
    
    public override void Bind() {
        base.Bind();
        // Use this.LevelRoot to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
        if (_BindFinishCurrentLevel) {
            this.BindButtonToCommand(_FinishCurrentLevelButton, this.LevelRoot.FinishCurrentLevel);
        }
    }
    
    public virtual void ExecuteFinishCurrentLevel() {
        LevelRoot.FinishCurrentLevel.OnNext(new FinishCurrentLevelCommand() { Sender = LevelRoot });
    }
    
    public virtual void ExecuteFinishCurrentLevel(FinishCurrentLevelCommand command) {
        command.Sender = LevelRoot;
        LevelRoot.FinishCurrentLevel.OnNext(command);
    }
}
