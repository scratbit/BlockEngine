using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockEngine.Core.DataTypes
{
    class BlockProperties
    {
        public enum BlockT
        {
            Liquid,
            Solid,
            TransparentSolid,
        }
        public enum BreakT
        {
            StoneLike,
            DirtLike,
            WoodLike
        }
        public enum DrawT
        {
            XVisibleAllSides,
            XVisiblePlayerSide,
            HashVisibleAllSides,
            HashVisiblePlayerSide,
            Block,
            Model
        }
        public BlockT BlockType = BlockT.Solid;

        #region Liquid Block Properties
        public bool Finite;
        public Engine.Texture InsideLiquidOverlay;
        public byte WaterSpreadLimit; //Applies only to infinite liquids
        public byte Density; //Used to tell how fast the player sinks and swims in it. 3 is more like water, 255 would be like thick pudding
        #endregion

        #region Solid Block Properties
        public BreakT BlockBreakType;
        public byte Hardness; //255 would take 15 seconds with the strongest of tools, 2 would break instantly, 1 is unbreakable
        public bool Walkable; //Is the player able to walk/fall/jump through it? True for yes
        public DrawT DrawType;
        public string FormSpec; //This will be used in the modding API later.
        #endregion

        #region Global Block Properties
        public short ID;
        public string Name;
        public bool EmitsLight;
        public bool Transparent;
        public byte LightLevel;
        public byte LightColor;
        public Engine.TextureCube Texture;
        public bool Flammable;
        #endregion

        public BlockProperties()
        {

        }
        /// <summary>
        /// Initializes a new instance of BlockProperties using another instance of BlockProperties as a base that can be easily modified.
        /// </summary>
        /// <param name="Properties"></param>
        public BlockProperties(BlockProperties Properties)
        {
            this.Finite = Properties.Finite;
            this.InsideLiquidOverlay = Properties.InsideLiquidOverlay;
            this.WaterSpreadLimit = Properties.WaterSpreadLimit;
            this.Density = Properties.Density;
            this.BlockBreakType = Properties.BlockBreakType;
            this.Hardness = Properties.Hardness;
            this.Walkable = Properties.Walkable;
            this.DrawType = Properties.DrawType;
            this.FormSpec = Properties.FormSpec;
            this.ID = Properties.ID;
            this.Name = Properties.Name;
            this.EmitsLight = Properties.EmitsLight;
            this.Transparent = Properties.Transparent;
            this.LightLevel = Properties.LightLevel;
            this.LightColor = Properties.LightColor;
            this.Texture = Properties.Texture;
            this.Flammable = Properties.Flammable;
        }
    }
}
