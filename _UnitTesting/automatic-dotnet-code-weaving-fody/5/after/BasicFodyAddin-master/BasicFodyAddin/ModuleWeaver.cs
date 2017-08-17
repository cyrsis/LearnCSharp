using System;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Rocks;
using Mono.Cecil.Cil;

public class ModuleWeaver
{
    // Will log an informational message to MSBuild
    public Action<string> LogInfo { get; set; }

    // An instance of Mono.Cecil.ModuleDefinition for processing
    public ModuleDefinition ModuleDefinition { get; set; }

    TypeSystem typeSystem;

    // Init logging delegates to make testing easier
    public ModuleWeaver()
    {
        LogInfo = m => { };
    }

    public void Execute()
    {
        typeSystem = ModuleDefinition.TypeSystem;

        var ifDef = new TypeDefinition("MarkerInterfaces",
            "IDTOMarkerInterface",
            TypeAttributes.Interface | TypeAttributes.Public | TypeAttributes.Abstract);

        ModuleDefinition.Types.Add(ifDef);

        var dtos = ModuleDefinition.GetTypes().Where(x => x.Name.EndsWith("DTO"));

        foreach (var dto in dtos)
        {
            dto.Interfaces.Add(ifDef);
        }
    }

  
}