# site-serve-debug.ps1
# https://jekyllrb.com/docs/configuration/options/
#
# Verbose output: `--verbose`
# Print verbose output.
#
# Trace: `--trace`
# Show the full backtrace when an error occurs.
#
# Regeneration: `--watch`
# Enable auto-regeneration of the site when files are modified.
#
# Live reload: `--livereload`
# Reload a page automatically on the browser when its content is edited.
#
# Incremental build: `--incremental`
# Enable the experimental incremental build feature.
# Incremental build only re-builds posts and pages that have changed, resulting in significant
# performance improvements for large sites, but may also break site generation in certain cases.
#
# Base URL: `--baseurl`
# Serve the website from the given base URL.
#
# Configuration: `--config`
# Specify config files instead of using _config.yml automatically.
# Settings in later files override settings in earlier files.


# Store the current directory.
$location = Get-Location

# Set the environment variable for Jekyll.
$Env:JEKYLL_ENV = "development"

# Try block to ensure finally gets called even if the script is stopped manually.
try
{
	# Change directory to the site source folder.
	Set-Location -Path .\docs

		# Launches the default browser to localhost at port 4000.
	Start-Process "http://localhost:4000/"

	# Run Jekyll serve with development configurations and parameters.
	bundle exec jekyll serve --verbose --trace --watch --livereload --incremental --baseurl="" --config "_config.yml,_config.debug.yml"
}
finally
{
	# Changes the directory back to the original location.
	Set-Location -Path $location
}
