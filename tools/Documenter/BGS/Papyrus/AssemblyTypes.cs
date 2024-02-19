namespace BGS.Papyrus;

public sealed class AssemblyScript
{
	public AssemblyInfo Info { get; set; }
	public IEnumerable<AssemblyUserFlag> UserFlagsRef { get; set; }
	public IEnumerable<AssemblyObject> ObjectTable { get; set; }

	public AssemblyScript()
	{
		Info = new AssemblyInfo();
		UserFlagsRef = Array.Empty<AssemblyUserFlag>();
		ObjectTable = Array.Empty<AssemblyObject>();
	}
}


public sealed class AssemblyInfo
{
	public string Source { get; set; }
	public int ModifyTime { get; set; }
	public int CompileTime { get; set; }
	public string User { get; set; }
	public string Computer { get; set; }

	public AssemblyInfo()
	{
		Source = string.Empty;
		ModifyTime = 0;
		CompileTime = 0;
		User = string.Empty;
		Computer = string.Empty;
	}
}


public sealed class AssemblyUserFlag
{
	public string Name { get; set; }
	public int Value { get; set; }
	public string? Debug { get; set; }

	public AssemblyUserFlag()
	{
		Name = string.Empty;
		Value = 0;
		Debug = null;
	}
}


public sealed class AssemblyObject
{
	public string Name { get; set; }
	public string Extends { get; set; }
	public int UserFlags { get; set; }
	public string DocString { get; set; }
	public string AutoState { get; set; }
	public IEnumerable<AssemblyStructure> StructTable { get; set; }
	public IEnumerable<AssemblyVariable> VariableTable { get; set; }
	public IEnumerable<AssemblyProperty> PropertyTable { get; set; }
	public IEnumerable<AssemblyPropertyGroup> PropertyGroupTable { get; set; }
	public IEnumerable<AssemblyState> StateTable { get; set; }

	public AssemblyObject()
	{
		Name = string.Empty;
		Extends = string.Empty;
		UserFlags = 0;
		DocString = string.Empty;
		AutoState = string.Empty;
		StructTable = Array.Empty<AssemblyStructure>();
		VariableTable = Array.Empty<AssemblyVariable>();
		PropertyTable = Array.Empty<AssemblyProperty>();
		PropertyGroupTable = Array.Empty<AssemblyPropertyGroup>();
		StateTable = Array.Empty<AssemblyState>();
	}
}


public sealed class AssemblyStructure
{
	public string Name { get; set; }

	public IEnumerable<AssemblyVariable> Variables { get; set; }

	public AssemblyStructure()
	{
		Name = string.Empty;
		Variables = Array.Empty<AssemblyVariable>();
	}
}


public sealed class AssemblyVariable
{
	public string Name { get; set; }
	public string Type { get; set; }
	public int UserFlags { get; set; }
	public string InitialValue { get; set; }
	public string DocString { get; set; }

	public AssemblyVariable()
	{
		Name = string.Empty;
		Type = string.Empty;
		UserFlags = 0;
		InitialValue = string.Empty;
		DocString = string.Empty;
	}
}


public sealed class AssemblyProperty
{
	public string Name { get; set; }
	public string Type { get; set; }
	public bool IsAuto { get; set; }
	public int UserFlags { get; set; }
	public string DocString { get; set; }
	public string AutoVar { get; set; }

	public AssemblyProperty()
	{
		Name = string.Empty;
		Type = string.Empty;
		IsAuto = false;
		UserFlags = 0;
		AutoVar = string.Empty;
		DocString = string.Empty;
	}
}


public sealed class AssemblyPropertyGroup
{
	public string Name { get; set; }
	public int UserFlags { get; set; }
	public string DocString { get; set; }
	public IEnumerable<string> Properties { get; set; }

	public AssemblyPropertyGroup()
	{
		Name = string.Empty;
		UserFlags = 0;
		DocString = string.Empty;
		Properties = Array.Empty<string>();
	}
}


public sealed class AssemblyState
{
	public string Name { get; set; }

	public IEnumerable<AssemblyFunction> Functions { get; set; }

	public AssemblyState()
	{
		Name = string.Empty;
		Functions = Array.Empty<AssemblyFunction>();
	}
}


public sealed class AssemblyFunction
{
	public string Name { get; set; }
	public bool Static { get; set; }
	public int UserFlags { get; set; }
	public string DocString { get; set; }
	public string Return { get; set; }
	public IEnumerable<AssemblyParameter> ParamTable { get; set; }
	public IEnumerable<AssemblyLocal> LocalTable { get; set; }
	public string Code { get; set; }

	public AssemblyFunction()
	{
		Name = string.Empty;
		Static = false;
		UserFlags = 0;
		DocString = string.Empty;
		Return = string.Empty;
		ParamTable = Array.Empty<AssemblyParameter>();
		LocalTable = Array.Empty<AssemblyLocal>();
		Code = string.Empty;
	}
}


public sealed class AssemblyParameter
{
	public string Name { get; set; }
	public string Type { get; set; }

	public AssemblyParameter()
	{
		Name = string.Empty;
		Type = string.Empty;
	}
}


public sealed class AssemblyLocal
{
	public string Name { get; set; }
	public string Type { get; set; }

	public AssemblyLocal()
	{
		Name = string.Empty;
		Type = string.Empty;
	}
}
