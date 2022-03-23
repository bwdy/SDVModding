﻿using StardewModdingAPI;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonMinecarts
{
    internal class AssetLoader : IAssetLoader
    {
        public bool CanLoad<T>(IAssetInfo asset) => asset.AssetNameEquals("JsonMinecarts.Minecarts");
        public T Load<T>(IAssetInfo asset)
        {
            return (T)(object)new Dictionary<string, MinecartInstance>()
            {
                {"jsonminecarts.busstop", new MinecartInstance() { UniqueId = "jsonminecarts.busstop", VanillaPassthrough = "Minecart_Bus", DisplayName = Game1.content.LoadString("Strings\\Locations:MineCart_Destination_BusStop"), LocationName = "BusStop", LandingPointX = 4, LandingPointY = 4, LandingPointDirection = 2, IsUnderground = false, MailCondition = null }},
                {"jsonminecarts.town", new MinecartInstance() { UniqueId = "jsonminecarts.town", VanillaPassthrough = "Minecart_Town", DisplayName = Game1.content.LoadString("Strings\\Locations:MineCart_Destination_Town"), LocationName = "Town", LandingPointX = 105, LandingPointY = 80, LandingPointDirection = 1, IsUnderground = false, MailCondition = null }},
                {"jsonminecarts.mines", new MinecartInstance() { UniqueId = "jsonminecarts.mines", VanillaPassthrough = "Minecart_Mines", DisplayName = Game1.content.LoadString("Strings\\Locations:MineCart_Destination_Mines"), LocationName = "Mine", LandingPointX = 13, LandingPointY = 9, LandingPointDirection = 1, IsUnderground = true, MailCondition = null }},
                {"jsonminecarts.quarry", new MinecartInstance() { UniqueId = "jsonminecarts.quarry", VanillaPassthrough = "Minecart_Quarry", DisplayName = Game1.content.LoadString("Strings\\Locations:MineCart_Destination_Quarry"), LocationName = "Mountain", LandingPointX = 124, LandingPointY = 12, LandingPointDirection = 2, IsUnderground = false, MailCondition = "ccCraftsRoom" }}
            };
        }
    }
}