namespace Documenter;

public sealed class Project
{

	public string? Name { get; set; }

	public string? OutputDirectory { get; set; }

	public string? ScriptDirectory { get; set; }


	public override string? ToString()
	{
		if (!string.IsNullOrWhiteSpace(Name))
			return Name;
		else
			return base.ToString();
	}


}
