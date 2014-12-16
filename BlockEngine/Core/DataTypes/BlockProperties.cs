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
        public Engine.Texture insideLiquidOverlay;
        public byte density; //Used to tell how fast the player sinks and swims in it. 3 is more like water, 255 would be like thick pudding
        public byte viscosity;
        #endregion

        #region Solid Block Properties
        public BreakT blockBreakType;
        public byte hardness; //255 would take 15 seconds with the strongest of tools, 2 would break instantly, 1 is unbreakable
        public bool walkable; //Is the player able to walk/fall/jump through it? True for yes
        public DrawT drawType;
        public string formSpec; //This will be used in the modding API later.
        #endregion

        #region Global Block Properties
        public short id;
        public string name;
        public bool emitsLight;
        public bool transparent;
        public byte lightLevel;
        public byte lightColor;
        public Engine.TextureCube texture;
        public bool flammable;
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
            this.insideLiquidOverlay = Properties.insideLiquidOverlay;
            this.density = Properties.density;
            this.blockBreakType = Properties.blockBreakType;
            this.hardness = Properties.hardness;
            this.walkable = Properties.walkable;
            this.drawType = Properties.drawType;
            this.formSpec = Properties.formSpec;
            this.id = Properties.id;
            this.name = Properties.name;
            this.emitsLight = Properties.emitsLight;
            this.transparent = Properties.transparent;
            this.lightLevel = Properties.lightLevel;
            this.lightColor = Properties.lightColor;
            this.texture = Properties.texture;
            this.flammable = Properties.flammable;
        }
    }
}
