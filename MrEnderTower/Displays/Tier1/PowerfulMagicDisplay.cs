using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;

namespace MrEnderTower.Displays.Tier1
{
    public class PowerfulMagicDisplay : ModTowerDisplay<MrEnderTower>
    {
        public override string BaseDisplay => GetDisplay(TowerType.WizardMonkey, 0, 0, 0);

        public override bool UseForTower(int[] tiers)
        {
            return tiers[2] == 1;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            node.RemoveBone("SuperMonkeyRig:Dart");
            // PrintInfo() showed this has multiple SkinnedMeshRenderers, so have to specify the index
        }
    }
}