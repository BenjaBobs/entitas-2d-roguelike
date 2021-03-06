//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public TurnBasedComponent turnBased { get { return (TurnBasedComponent)GetComponent(ComponentIds.TurnBased); } }

        public bool hasTurnBased { get { return HasComponent(ComponentIds.TurnBased); } }

        public Entity AddTurnBased(int newIndex, float newDelay) {
            var component = CreateComponent<TurnBasedComponent>(ComponentIds.TurnBased);
            component.index = newIndex;
            component.delay = newDelay;
            return AddComponent(ComponentIds.TurnBased, component);
        }

        public Entity ReplaceTurnBased(int newIndex, float newDelay) {
            var component = CreateComponent<TurnBasedComponent>(ComponentIds.TurnBased);
            component.index = newIndex;
            component.delay = newDelay;
            ReplaceComponent(ComponentIds.TurnBased, component);
            return this;
        }

        public Entity RemoveTurnBased() {
            return RemoveComponent(ComponentIds.TurnBased);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherTurnBased;

        public static IMatcher TurnBased {
            get {
                if (_matcherTurnBased == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.TurnBased);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherTurnBased = matcher;
                }

                return _matcherTurnBased;
            }
        }
    }
}
