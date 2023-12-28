# site-serve.ps1

# Store the current directory
$originalLocation = Get-Location

# Set the environment variable for Jekyll.
$Env:JEKYLL_ENV = "development"

# Try block to ensure finally gets called even if the script is stopped manually
try
{
	# Change directory to the site source folder.
	Set-Location -Path .\docs

	# Run Jekyll serve with the development debug configurations
	bundle exec jekyll serve --baseurl="" --watch --livereload --incremental
}
finally
{
	# Changes the directory back to the original location.
	Set-Location -Path $originalLocation
}
