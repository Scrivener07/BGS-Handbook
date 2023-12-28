# site-serve-debug.ps1

# Set the environment variable for Jekyll
$Env:JEKYLL_ENV = "development"

# Run Jekyll serve with the desired exclusions
bundle exec jekyll serve --baseurl="" --watch --livereload --incremental --config "_config.yml,_config.debug.yml"
