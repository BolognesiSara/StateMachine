using UnityEngine;

[CreateAssetMenu(menuName = "Pluggable AI/Actions/Attack")]
public class Attack : Action {
    
    public override void Act(StateController controller) {
        controller.Attack(controller);
    }
}
