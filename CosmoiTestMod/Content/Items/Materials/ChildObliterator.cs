using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace CosmoiTestMod.Content.Items.Materials
{
    public class ChildObliterator : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 40; 
            Item.height = 40;
            Item.scale = 2f;
            Item.rare = -12;

            Item.damage = 2000000000;
            Item.DamageType = DamageClass.Melee;

            Item.useTime = 1;
            Item.useAnimation = 20;

            Item.knockBack = 20f;
            Item.autoReuse = true;

            Item.value = 2000000000;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(3467, 1000);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}