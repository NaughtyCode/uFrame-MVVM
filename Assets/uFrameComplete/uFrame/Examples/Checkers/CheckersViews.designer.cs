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
using System.Linq;
using UnityEngine;


[DiagramInfoAttribute("Checkers")]
public abstract class CheckerBoardViewBase : ViewBase {
    
    [UnityEngine.SerializeField()]
    private NewViewComponent _NewViewComponent;
    
    [UFToggleGroup("Checkers")]
    [UnityEngine.HideInInspector()]
    public bool _BindCheckers;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<CheckerViewBase> _CheckersList;
    
    [UFGroup("Checkers")]
    [UnityEngine.HideInInspector()]
    public bool _CheckersSceneFirst;
    
    [UFGroup("Checkers")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _CheckersContainer;
    
    [UFToggleGroup("Plates")]
    [UnityEngine.HideInInspector()]
    public bool _BindPlates;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<CheckerPlateViewBase> _PlatesList;
    
    [UFGroup("Plates")]
    [UnityEngine.HideInInspector()]
    public bool _PlatesSceneFirst;
    
    [UFGroup("Plates")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _PlatesContainer;
    
    public override string DefaultIdentifier {
        get {
            return "CheckerBoard";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckerBoardViewModel);
        }
    }
    
    public virtual NewViewComponent NewViewComponent {
        get {
            return _NewViewComponent ?? (_NewViewComponent = GetComponent<NewViewComponent>());
        }
        set {
            this._NewViewComponent = value;
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public CheckerBoardViewModel CheckerBoard {
        get {
            return ((CheckerBoardViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void CheckersAdded(CheckerViewBase checker) {
        this._CheckersList.Add(checker);
    }
    
    public virtual void CheckersRemoved(CheckerViewBase checker) {
        this._CheckersList.Remove(checker);
        UnityEngine.Object.Destroy(checker.gameObject);
    }
    
    public virtual ViewBase CreateCheckersView(CheckerViewModel checker) {
        return this.InstantiateView(checker);
    }
    
    public virtual void PlatesAdded(CheckerPlateViewBase checkerPlate) {
        this._PlatesList.Add(checkerPlate);
    }
    
    public virtual void PlatesRemoved(CheckerPlateViewBase checkerPlate) {
        this._PlatesList.Remove(checkerPlate);
        UnityEngine.Object.Destroy(checkerPlate.gameObject);
    }
    
    public virtual ViewBase CreatePlatesView(CheckerPlateViewModel checkerPlate) {
        return this.InstantiateView(checkerPlate);
    }
    
    public override void Bind() {
        if (this._BindCheckers) {
            var binding = this.BindToViewCollection(() => CheckerBoard._CheckersProperty);
            binding.SetAddHandler(item=>CheckersAdded(item as CheckerViewBase));
            binding.SetRemoveHandler(item=>CheckersRemoved(item as CheckerViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreateCheckersView(viewModel as CheckerViewModel); }); ;
            if ((_CheckersContainer == null)) {
            }
            else {
                binding.SetParent(_CheckersContainer);
            }
            if (_CheckersSceneFirst) {
                binding.ViewFirst();
            }
        }
        if (this._BindPlates) {
            var binding = this.BindToViewCollection(() => CheckerBoard._PlatesProperty);
            binding.SetAddHandler(item=>PlatesAdded(item as CheckerPlateViewBase));
            binding.SetRemoveHandler(item=>PlatesRemoved(item as CheckerPlateViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreatePlatesView(viewModel as CheckerPlateViewModel); }); ;
            if ((_PlatesContainer == null)) {
            }
            else {
                binding.SetParent(_PlatesContainer);
            }
            if (_PlatesSceneFirst) {
                binding.ViewFirst();
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckerBoardController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}


[DiagramInfoAttribute("Checkers")]
public abstract class CheckerMoveViewBase : ViewBase {
    
    public override string DefaultIdentifier {
        get {
            return "CheckerMove";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckerMoveViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public CheckerMoveViewModel CheckerMove {
        get {
            return ((CheckerMoveViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override void Bind() {
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckerMoveController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class CheckerPlateViewBase : ViewBase {
    
    [UFToggleGroup("CanMoveTo")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CanMoveToChanged")]
    public bool _BindCanMoveTo;
    
    [UFToggleGroup("Position")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("PositionChanged")]
    public bool _BindPosition;
    
    [UFToggleGroup("IsEven")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("IsEvenChanged")]
    public bool _BindIsEven;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public bool _CanMoveTo;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Vector2 _Position;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public bool _IsEven;
    
    public override string DefaultIdentifier {
        get {
            return "CheckerPlate";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckerPlateViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public CheckerPlateViewModel CheckerPlate {
        get {
            return ((CheckerPlateViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void CanMoveToChanged(bool value) {
    }
    
    public virtual void PositionChanged(UnityEngine.Vector2 value) {
    }
    
    public virtual void IsEvenChanged(bool value) {
    }
    
    public override void Bind() {
        if (this._BindCanMoveTo) {
            this.BindProperty(()=>CheckerPlate._CanMoveToProperty, this.CanMoveToChanged);
        }
        if (this._BindPosition) {
            this.BindProperty(()=>CheckerPlate._PositionProperty, this.PositionChanged);
        }
        if (this._BindIsEven) {
            this.BindProperty(()=>CheckerPlate._IsEvenProperty, this.IsEvenChanged);
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckerPlateController>());
    }
    
    public virtual void ExecuteSelectCommand() {
        this.ExecuteCommand(CheckerPlate.SelectCommand);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        CheckerPlateViewModel checkerPlate = ((CheckerPlateViewModel)(viewModel));
        checkerPlate.CanMoveTo = this._CanMoveTo;
        checkerPlate.Position = this._Position;
        checkerPlate.IsEven = this._IsEven;
    }
}


[DiagramInfoAttribute("Checkers")]
public abstract class CheckersGameViewBase : ViewBase {
    
    [UFToggleGroup("BlackScore")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("BlackScoreChanged")]
    public bool _BindBlackScore;
    
    [UFToggleGroup("Board")]
    [UnityEngine.HideInInspector()]
    public bool _BindBoard;
    
    [UFGroup("Board")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.GameObject _BoardPrefab;
    
    [UFToggleGroup("CurrentChecker")]
    [UnityEngine.HideInInspector()]
    public bool _BindCurrentChecker;
    
    [UFGroup("CurrentChecker")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.GameObject _CurrentCheckerPrefab;
    
    [UFToggleGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CurrentPlayerChanged")]
    public bool _BindCurrentPlayer;
    
    [UFToggleGroup("RedScore")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("RedScoreChanged")]
    public bool _BindRedScore;
    
    [UFToggleGroup("AllowedMoves")]
    [UnityEngine.HideInInspector()]
    public bool _BindAllowedMoves;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<CheckerMoveViewBase> _AllowedMovesList;
    
    [UFGroup("AllowedMoves")]
    [UnityEngine.HideInInspector()]
    public bool _AllowedMovesSceneFirst;
    
    [UFGroup("AllowedMoves")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _AllowedMovesContainer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _BlackScore;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _Board;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _CurrentChecker;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public CheckerType _CurrentPlayer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _RedScore;
    
    public override string DefaultIdentifier {
        get {
            return "CheckersGame";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckersGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public CheckersGameViewModel CheckersGame {
        get {
            return ((CheckersGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void BlackScoreChanged(int value) {
    }
    
    public virtual void BoardChanged(CheckerBoardViewModel value) {
        if (value == null && _BoardPrefab != null) {
            Destroy(_Board.gameObject);
        }
        if (_BoardPrefab == null ) {
            this._Board = ((CheckerBoardViewBase)(this.InstantiateView(value)));
        }
        else {
            this._Board = ((CheckerBoardViewBase)(this.InstantiateView(this._BoardPrefab, value)));
        }
    }
    
    public virtual void CurrentCheckerChanged(CheckerViewModel value) {
        if (value == null && _CurrentCheckerPrefab != null) {
            Destroy(_CurrentChecker.gameObject);
        }
        if (_CurrentCheckerPrefab == null ) {
            this._CurrentChecker = ((CheckerViewBase)(this.InstantiateView(value)));
        }
        else {
            this._CurrentChecker = ((CheckerViewBase)(this.InstantiateView(this._CurrentCheckerPrefab, value)));
        }
    }
    
    public virtual void CurrentPlayerChanged(CheckerType value) {
    }
    
    public virtual void RedScoreChanged(int value) {
    }
    
    public virtual void AllowedMovesAdded(CheckerMoveViewBase checkerMove) {
        this._AllowedMovesList.Add(checkerMove);
    }
    
    public virtual void AllowedMovesRemoved(CheckerMoveViewBase checkerMove) {
        this._AllowedMovesList.Remove(checkerMove);
        UnityEngine.Object.Destroy(checkerMove.gameObject);
    }
    
    public virtual ViewBase CreateAllowedMovesView(CheckerMoveViewModel checkerMove) {
        return this.InstantiateView(checkerMove);
    }
    
    public override void Bind() {
        if (this._BindBlackScore) {
            this.BindProperty(()=>CheckersGame._BlackScoreProperty, this.BlackScoreChanged);
        }
        if (this._BindBoard) {
            this.BindProperty(()=>CheckersGame._BoardProperty, this.BoardChanged);
        }
        if (this._BindCurrentChecker) {
            this.BindProperty(()=>CheckersGame._CurrentCheckerProperty, this.CurrentCheckerChanged);
        }
        if (this._BindCurrentPlayer) {
            this.BindProperty(()=>CheckersGame._CurrentPlayerProperty, this.CurrentPlayerChanged);
        }
        if (this._BindRedScore) {
            this.BindProperty(()=>CheckersGame._RedScoreProperty, this.RedScoreChanged);
        }
        if (this._BindAllowedMoves) {
            var binding = this.BindToViewCollection(() => CheckersGame._AllowedMovesProperty);
            binding.SetAddHandler(item=>AllowedMovesAdded(item as CheckerMoveViewBase));
            binding.SetRemoveHandler(item=>AllowedMovesRemoved(item as CheckerMoveViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreateAllowedMovesView(viewModel as CheckerMoveViewModel); }); ;
            if ((_AllowedMovesContainer == null)) {
            }
            else {
                binding.SetParent(_AllowedMovesContainer);
            }
            if (_AllowedMovesSceneFirst) {
                binding.ViewFirst();
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckersGameController>());
    }
    
    public virtual void ExecuteGameOver() {
        this.ExecuteCommand(CheckersGame.GameOver);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        CheckersGameViewModel checkersGame = ((CheckersGameViewModel)(viewModel));
        checkersGame.BlackScore = this._BlackScore;
        checkersGame.Board = this._Board == null ? null : this._Board.ViewModelObject as CheckerBoardViewModel;
        checkersGame.CurrentChecker = this._CurrentChecker == null ? null : this._CurrentChecker.ViewModelObject as CheckerViewModel;
        checkersGame.CurrentPlayer = this._CurrentPlayer;
        checkersGame.RedScore = this._RedScore;
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class CheckerViewBase : ViewBase {
    
    [UnityEngine.SerializeField()]
    private KingMeStrategy _KingMeStrategy;
    
    [UnityEngine.SerializeField()]
    private ContiniousRotation _ContiniousRotation;
    
    [UFToggleGroup("IsKingMe")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("IsKingMeChanged")]
    public bool _BindIsKingMe;
    
    [UFToggleGroup("Position")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("PositionChanged")]
    public bool _BindPosition;
    
    [UFToggleGroup("Selected")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SelectedChanged")]
    public bool _BindSelected;
    
    [UFToggleGroup("Type")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("TypeChanged")]
    public bool _BindType;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public bool _IsKingMe;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Vector2 _Position;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public bool _Selected;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public CheckerType _Type;
    
    public override string DefaultIdentifier {
        get {
            return "Checker";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckerViewModel);
        }
    }
    
    public virtual KingMeStrategy KingMeStrategy {
        get {
            return _KingMeStrategy ?? (_KingMeStrategy = GetComponent<KingMeStrategy>());
        }
        set {
            this._KingMeStrategy = value;
        }
    }
    
    public virtual ContiniousRotation ContiniousRotation {
        get {
            return _ContiniousRotation ?? (_ContiniousRotation = GetComponent<ContiniousRotation>());
        }
        set {
            this._ContiniousRotation = value;
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public CheckerViewModel Checker {
        get {
            return ((CheckerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void IsKingMeChanged(bool value) {
    }
    
    public virtual void PositionChanged(UnityEngine.Vector2 value) {
    }
    
    public virtual void SelectedChanged(bool value) {
    }
    
    public virtual void TypeChanged(CheckerType value) {
    }
    
    public override void Bind() {
        if (this._BindIsKingMe) {
            this.BindProperty(()=>Checker._IsKingMeProperty, this.IsKingMeChanged);
        }
        if (this._BindPosition) {
            this.BindProperty(()=>Checker._PositionProperty, this.PositionChanged);
        }
        if (this._BindSelected) {
            this.BindProperty(()=>Checker._SelectedProperty, this.SelectedChanged);
        }
        if (this._BindType) {
            this.BindProperty(()=>Checker._TypeProperty, this.TypeChanged);
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckerController>());
    }
    
    public virtual void ExecuteSelectCommand() {
        this.ExecuteCommand(Checker.SelectCommand);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        CheckerViewModel checker = ((CheckerViewModel)(viewModel));
        checker.IsKingMe = this._IsKingMe;
        checker.Position = this._Position;
        checker.Selected = this._Selected;
        checker.Type = this._Type;
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class AICheckersGameViewBase : CheckersGameViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(AICheckersGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public AICheckersGameViewModel AICheckersGame {
        get {
            return ((AICheckersGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<AICheckersGameController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class MainMenuViewBase : ViewBase {
    
    public override string DefaultIdentifier {
        get {
            return "MainMenu";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(MainMenuViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public MainMenuViewModel MainMenu {
        get {
            return ((MainMenuViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override void Bind() {
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<MainMenuController>());
    }
    
    public virtual void ExecutePlay() {
        this.ExecuteCommand(MainMenu.Play);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

public partial class CheckerPlateView : CheckerPlateViewBase {
}

public partial class CheckerBoardView : CheckerBoardViewBase {
}

public partial class CheckerView : CheckerViewBase {
}

public partial class CheckersGameView : CheckersGameViewBase {
}

public partial class CheckersHudView : CheckersGameViewBase {
}

public partial class MainMenuView : MainMenuViewBase {
}

public partial class NewViewComponent : ViewComponent {
    
    public virtual CheckerBoardViewModel CheckerBoard {
        get {
            return ((CheckerBoardViewModel)(this.View.ViewModelObject));
        }
    }
}

public partial class NewViewComponent1 : NewViewComponent {
}

public partial class KingMeStrategy : ViewComponent {
    
    public virtual CheckerViewModel Checker {
        get {
            return ((CheckerViewModel)(this.View.ViewModelObject));
        }
    }
    
    public virtual void ExecuteSelectCommand() {
        this.View.ExecuteCommand(Checker.SelectCommand);
    }
}

public partial class DoubleUpKingMeStrategy : KingMeStrategy {
}

public partial class FlipOverKingMeStrategy : KingMeStrategy {
}

public partial class ContiniousRotation : ViewComponent {
    
    public virtual CheckerViewModel Checker {
        get {
            return ((CheckerViewModel)(this.View.ViewModelObject));
        }
    }
    
    public virtual void ExecuteSelectCommand() {
        this.View.ExecuteCommand(Checker.SelectCommand);
    }
}

public partial class MapView : ContiniousRotation {
}

public partial class PlayerScreenView : ContiniousRotation {
}
