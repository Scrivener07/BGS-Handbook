## Usage:
```
Archive2 <archive, files/folders> [<arguments>]
archive        Specifies the archive to open (for extracting/opening an archive).
files/folders  Specifies the files and folders to open (for making an archive, comma-delimited).
```

### Arguments
Zero or more of the following:

-sourceFile|s=<string> - quotes required if spaces are involved
   Sets the source file to find contents to archive

-excludeFile=<string> - quotes required if spaces are involved
   Sets the file that lists files not to archive

-create|c=<string> - quotes required if spaces are involved
   Tells archiver to create an archive with the specified name

-extract|e=<string> - quotes required if spaces are involved
   Tells the archiver to extract an archive to the specified folder

-root|r=<string> - quotes required if spaces are involved
   Tells the archiver what path to use for the archive root (instead of looking for a data folder)

-format|f=<General|DDS|XBoxDDS|GNF>
   Sets the archive format (default - General)

-compression=<None|Default|XBox>
   Sets the file compression settings (default - Default)

-count=<unsigned int>
   Sets the archive count to make (default - 0)

-maxSizeMB|sMB=<unsigned int>
   Sets the maximum archive size in megabytes (default - 0)

-maxChunkCount|mch=<unsigned int>
   Sets the maximum number of chunks to use in a file (default - 4)

-singleMipChunkX|mipX=<unsigned int>
   Sets the X component of the minimum size a mip should be to have its own chunk (default - 512)

-singleMipChunkY|mipY=<unsigned int>
   Sets the Y component of the minimum size a mip should be to have its own chunk (default - 512)

-nostrings
   Does not write a string table to the archive

-quiet|q
   Does not report progress or success (only failures)

-tempFiles
   Tells the archiver to use temporary files instead of loading chunks into memory. Slower, but reduces memory usage

-cleanup
   Cleans up chunk temp folder on launch (do not use when multiple copies are running)

-includeFilters=??
   A list of regular expressions for file inclusion.

-excludeFilters=??
   A list of regular expressions for file exclusion.

-?
   Prints usage information.


## Extraction

```bat
Archive2.exe "Fallout4 - Misc.ba2" -sourceFile="base-targets.achlist" -extract="EXTRACTED"
```
