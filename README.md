# Scrivener's BGS Handbook
- Website: https://scrivener07.github.io/BGS-Handbook/

View [this](docs/site/index.md) for site information and debugging previews.


### See Also
- [Jekyll Documentation](https://jekyllrb.com/docs/)
- - [Site Variables](https://jekyllrb.com/docs/variables/#site-variables)
- - [Page Variables](https://jekyllrb.com/docs/variables/#page-variables)
- [Liquid Documentation](https://shopify.github.io/liquid/)


# Setup
- See also [Testing your GitHub Pages site locally with Jekyll](https://docs.github.com/en/pages/setting-up-a-github-pages-site-with-jekyll/testing-your-github-pages-site-locally-with-jekyll#updating-the-github-pages-gem).
- See also [GitHub Pages dependency versions](https://pages.github.com/versions/).
- See also [Jekyll for GitHub Pages](https://jekyllrb.com/docs/github-pages/).
- See also [Adding a theme to your GitHub Pages site using Jekyll](https://docs.github.com/en/pages/setting-up-a-github-pages-site-with-jekyll/adding-a-theme-to-your-github-pages-site-using-jekyll).
- See also [Jekyll Themes](https://jekyllrb.com/docs/themes/#overriding-theme-defaults).


#### Note: Do not use tabs in configuration files
Do not use tabs in configuration files.
This will either lead to parsing errors, or Jekyll will revert to the default settings.
Use spaces instead.


### Install
Follow the directions at [Creating a GitHub Pages site with Jekyll](https://docs.github.com/en/pages/setting-up-a-github-pages-site-with-jekyll/creating-a-github-pages-site-with-jekyll).
1. Run `jekyll new --skip-bundle .` to install project scaffolding.
2. Edit the `GemFile` per [Creating a GitHub Pages site with Jekyll](https://docs.github.com/en/pages/setting-up-a-github-pages-site-with-jekyll/creating-a-github-pages-site-with-jekyll)
- 1. Comment out the line that starts with `gem "jekyll"` to comment out this line.
- 2. Uncomment the `github-pages` gem by editing the line starting with `# gem "github-pages"`.
- 3. Change this line to: `gem "github-pages", "~> GITHUB-PAGES-VERSION", group: :jekyll_plugins`
- 4. Replace `GITHUB-PAGES-VERSION` with the latest supported version of the `github-pages` gem. You can find this version here: [Dependency versions](https://pages.github.com/versions/)
2. Run `bundle install` to install and update dependencies.

### Update
1. Run `bundle install` to install and update dependencies.
2. Run `bundle update webrick` to update the required gem.
3. Run `bundle update github-pages` to update the required gem.

### Configure
Edit the `_config.yml` file to finish configuring the site settings.


# Test Local
- Setup Guide: https://jekyllrb.com/docs/step-by-step/01-setup/
- Command `serve`: https://jekyllrb.com/docs/configuration/options/#serve-command-options

1. Run `bundle exec jekyll serve --baseurl=""` to start the server.
- Optionally run with `--watch` to enable auto-regeneration.
- Optionally run with `--livereload` reload a page automatically on the browser when its content is edited.
- Optionally run with `--incremental` to enable incremental build.
2. Test locally in your browser at the `http://localhost:4000` url.

#### Note: Run on Windows locally
If you've installed Ruby 3.0 or later, you might get an error at this step.
That's because these versions of Ruby no longer come with `webrick` installed.
To fix the error, try running `bundle add webrick`, then re-running `bundle exec jekyll serve` command.

#### Note: Run with incremental build
Incremental regeneration in Jekyll is an experimental feature that can help shorten build times by only generating documents and pages that have been updated since the previous build.
While incremental regeneration works well for common cases, it may not handle every scenario perfectly.
One such case would be that edits to `_includes` would not trigger a regeneration for associated pages.
This would require a full rebuild that incremental build mode doesn't work well with.
