# Store the current directory.
$location = Get-Location

# Try block to ensure finally gets called even if the script is stopped manually.
try
{
	# Change directory to the site source folder.
	Set-Location -Path .\docs

	# Run Jekyll serve with development configurations and parameters.
	bundle exec jekyll build --trace
}
finally
{
	# Changes the directory back to the original location.
	Set-Location -Path $location
}
