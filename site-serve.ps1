# site-serve.ps1

# Set the environment variable for Jekyll
$Env:JEKYLL_ENV = "development"

# Run Jekyll serve to start the site.
bundle exec jekyll serve --baseurl="" --watch --livereload --incremental
