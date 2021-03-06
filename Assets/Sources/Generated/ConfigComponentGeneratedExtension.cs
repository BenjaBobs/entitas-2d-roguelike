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
        public ConfigComponent config { get { return (ConfigComponent)GetComponent(ComponentIds.Config); } }

        public bool hasConfig { get { return HasComponent(ComponentIds.Config); } }

        public Entity AddConfig(int newColumns, int newRows, int newFoodCountMin, int newFoodCountMax, int newWallCountMin, int newWallCountMax, int newEnemyCountMultiplier, int newFoodPoints, int newSodaPoints, int newEnemy1Dmg, int newEnemy2Dmg, float newTurnDelay) {
            var component = CreateComponent<ConfigComponent>(ComponentIds.Config);
            component.columns = newColumns;
            component.rows = newRows;
            component.foodCountMin = newFoodCountMin;
            component.foodCountMax = newFoodCountMax;
            component.wallCountMin = newWallCountMin;
            component.wallCountMax = newWallCountMax;
            component.enemyCountMultiplier = newEnemyCountMultiplier;
            component.foodPoints = newFoodPoints;
            component.sodaPoints = newSodaPoints;
            component.enemy1Dmg = newEnemy1Dmg;
            component.enemy2Dmg = newEnemy2Dmg;
            component.turnDelay = newTurnDelay;
            return AddComponent(ComponentIds.Config, component);
        }

        public Entity ReplaceConfig(int newColumns, int newRows, int newFoodCountMin, int newFoodCountMax, int newWallCountMin, int newWallCountMax, int newEnemyCountMultiplier, int newFoodPoints, int newSodaPoints, int newEnemy1Dmg, int newEnemy2Dmg, float newTurnDelay) {
            var component = CreateComponent<ConfigComponent>(ComponentIds.Config);
            component.columns = newColumns;
            component.rows = newRows;
            component.foodCountMin = newFoodCountMin;
            component.foodCountMax = newFoodCountMax;
            component.wallCountMin = newWallCountMin;
            component.wallCountMax = newWallCountMax;
            component.enemyCountMultiplier = newEnemyCountMultiplier;
            component.foodPoints = newFoodPoints;
            component.sodaPoints = newSodaPoints;
            component.enemy1Dmg = newEnemy1Dmg;
            component.enemy2Dmg = newEnemy2Dmg;
            component.turnDelay = newTurnDelay;
            ReplaceComponent(ComponentIds.Config, component);
            return this;
        }

        public Entity RemoveConfig() {
            return RemoveComponent(ComponentIds.Config);
        }
    }

    public partial class Pool {
        public Entity configEntity { get { return GetGroup(Matcher.Config).GetSingleEntity(); } }

        public ConfigComponent config { get { return configEntity.config; } }

        public bool hasConfig { get { return configEntity != null; } }

        public Entity SetConfig(int newColumns, int newRows, int newFoodCountMin, int newFoodCountMax, int newWallCountMin, int newWallCountMax, int newEnemyCountMultiplier, int newFoodPoints, int newSodaPoints, int newEnemy1Dmg, int newEnemy2Dmg, float newTurnDelay) {
            if (hasConfig) {
                throw new EntitasException("Could not set config!\n" + this + " already has an entity with ConfigComponent!",
                    "You should check if the pool already has a configEntity before setting it or use pool.ReplaceConfig().");
            }
            var entity = CreateEntity();
            entity.AddConfig(newColumns, newRows, newFoodCountMin, newFoodCountMax, newWallCountMin, newWallCountMax, newEnemyCountMultiplier, newFoodPoints, newSodaPoints, newEnemy1Dmg, newEnemy2Dmg, newTurnDelay);
            return entity;
        }

        public Entity ReplaceConfig(int newColumns, int newRows, int newFoodCountMin, int newFoodCountMax, int newWallCountMin, int newWallCountMax, int newEnemyCountMultiplier, int newFoodPoints, int newSodaPoints, int newEnemy1Dmg, int newEnemy2Dmg, float newTurnDelay) {
            var entity = configEntity;
            if (entity == null) {
                entity = SetConfig(newColumns, newRows, newFoodCountMin, newFoodCountMax, newWallCountMin, newWallCountMax, newEnemyCountMultiplier, newFoodPoints, newSodaPoints, newEnemy1Dmg, newEnemy2Dmg, newTurnDelay);
            } else {
                entity.ReplaceConfig(newColumns, newRows, newFoodCountMin, newFoodCountMax, newWallCountMin, newWallCountMax, newEnemyCountMultiplier, newFoodPoints, newSodaPoints, newEnemy1Dmg, newEnemy2Dmg, newTurnDelay);
            }

            return entity;
        }

        public void RemoveConfig() {
            DestroyEntity(configEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherConfig;

        public static IMatcher Config {
            get {
                if (_matcherConfig == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Config);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherConfig = matcher;
                }

                return _matcherConfig;
            }
        }
    }
}
