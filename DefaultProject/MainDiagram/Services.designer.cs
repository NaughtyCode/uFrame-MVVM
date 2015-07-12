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
using UniRx;
using uFrame.Kernel;
using uFrame.MVVM;
using UnityEngine;


public class SceneFlowServiceBase : uFrame.Kernel.SystemServiceMonoBehavior {
    
    /// <summary>
    /// This method is invoked whenever the kernel is loading.
    /// Since the kernel lives throughout the entire lifecycle of the game, this will only be invoked once.
    /// </summary>
    public override void Setup() {
        base.Setup();
        this.OnEvent<IntroFinishedEvent>().Subscribe(this.IntroFinishedEventHandler);
        this.OnEvent<AssetLoadingProgressEvent>().Subscribe(this.AssetLoadingProgressEventHandler);
    }
    
    /// <summary>
    // This method is executed when using this.Publish(new IntroFinishedEvent())
    /// </summary>
    public virtual void IntroFinishedEventHandler(IntroFinishedEvent data) {
        // Process the commands information.  Also, you can publish new events by using the line below.
        // this.Publish(new AnotherEvent())
    }
    
    /// <summary>
    // This method is executed when using this.Publish(new AssetLoadingProgressEvent())
    /// </summary>
    public virtual void AssetLoadingProgressEventHandler(AssetLoadingProgressEvent data) {
        // Process the commands information.  Also, you can publish new events by using the line below.
        // this.Publish(new AnotherEvent())
    }
}

public class AssetLoadingServiceBase : uFrame.Kernel.SystemServiceMonoBehavior {
    
    /// <summary>
    /// This method is invoked whenever the kernel is loading.
    /// Since the kernel lives throughout the entire lifecycle of the game, this will only be invoked once.
    /// </summary>
    public override void Setup() {
        base.Setup();
        this.OnEvent<StartAssetLoadingCommand>().Subscribe(this.StartAssetLoadingCommandHandler);
    }
    
    /// <summary>
    // This method is executed when using this.Publish(new StartAssetLoadingCommand())
    /// </summary>
    public virtual void StartAssetLoadingCommandHandler(StartAssetLoadingCommand data) {
        // Process the commands information.  Also, you can publish new events by using the line below.
        // this.Publish(new AnotherEvent())
    }
}

public class SettingsServiceBase : uFrame.Kernel.SystemServiceMonoBehavior {
    
    /// <summary>
    /// This method is invoked whenever the kernel is loading.
    /// Since the kernel lives throughout the entire lifecycle of the game, this will only be invoked once.
    /// </summary>
    public override void Setup() {
        base.Setup();
    }
}
