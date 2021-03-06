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
        static readonly AIMoveTargetComponent aIMoveTargetComponent = new AIMoveTargetComponent();

        public bool isAIMoveTarget {
            get { return HasComponent(ComponentIds.AIMoveTarget); }
            set {
                if (value != isAIMoveTarget) {
                    if (value) {
                        AddComponent(ComponentIds.AIMoveTarget, aIMoveTargetComponent);
                    } else {
                        RemoveComponent(ComponentIds.AIMoveTarget);
                    }
                }
            }
        }

        public Entity IsAIMoveTarget(bool value) {
            isAIMoveTarget = value;
            return this;
        }
    }

    public partial class Pool {
        public Entity aIMoveTargetEntity { get { return GetGroup(Matcher.AIMoveTarget).GetSingleEntity(); } }

        public bool isAIMoveTarget {
            get { return aIMoveTargetEntity != null; }
            set {
                var entity = aIMoveTargetEntity;
                if (value != (entity != null)) {
                    if (value) {
                        CreateEntity().isAIMoveTarget = true;
                    } else {
                        DestroyEntity(entity);
                    }
                }
            }
        }
    }

    public partial class Matcher {
        static IMatcher _matcherAIMoveTarget;

        public static IMatcher AIMoveTarget {
            get {
                if (_matcherAIMoveTarget == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.AIMoveTarget);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherAIMoveTarget = matcher;
                }

                return _matcherAIMoveTarget;
            }
        }
    }
}
