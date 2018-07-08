﻿using ClassFileGenerator.Core.Meta;
using ClassFileGenerator.Core.Meta.Def;
using ClassFileGenerator.Core.Meta.Settings;
using ClassFileGenerator.Core.Meta.Def.Methods;

namespace ClassFileGenerator.Core.Templates.CSharp.Interface
{
    partial class Template : ITemplate
    {
        private readonly InterfaceMeta meta;

        public Template(InterfaceMeta meta)
        {
            this.meta = meta;
        }

        private string nameSpace => meta.NameSpace;
        private string interfaceName => meta.InterfaceName;
        private UsingDefinition[] usings => meta.UsingDefinitions;
        private MethodDefinition[] methods => meta.MethodDefinitions;
        private ImplementsSetting implementsSetting => meta.ImplementsSetting;
        private IArgumentFormatter formatter => new SimpleArgumenFormatter();
    }
}
