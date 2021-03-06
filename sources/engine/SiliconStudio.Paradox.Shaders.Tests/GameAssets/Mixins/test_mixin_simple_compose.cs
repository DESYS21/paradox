﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Paradox Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Paradox.VisualStudio.Package .vsix
// and re-save the associated .pdxfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Paradox.Effects;
using SiliconStudio.Paradox.Graphics;
using SiliconStudio.Paradox.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Paradox.Graphics.Buffer;

namespace Test6
{
    internal static partial class ShaderMixins
    {
        internal partial class DefaultSimpleCompose  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "A");
                context.Mixin(mixin, "B");
                context.Mixin(mixin, "C");

                {
                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };
                    context.PushComposition(mixin, "x", __subMixin);
                    context.Mixin(__subMixin, "X");
                    context.PopComposition();
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("DefaultSimpleCompose", new DefaultSimpleCompose());
            }
        }
    }
}
